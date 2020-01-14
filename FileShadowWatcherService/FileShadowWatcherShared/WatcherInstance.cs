using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FileShadowWatcherShared
{
    public class WatcherInstance
    {
        public WatcherFolderOption Options { get; set; }
        public FileSystemWatcher Watcher { get; set; }
        public string GUID { get; set; }
        public bool Listening { get; set; }

        public WatcherFactory Factory { get; set; }
        //public SnapshotFactory snapshotFactory { get; set; }

        private bool InitInstance(WatcherFactory watcherFactory)
        {
            try
            {
                Factory = watcherFactory;
                Watcher = new FileSystemWatcher();

                Watcher.InternalBufferSize = Options.InternalBufferSize < 4096 ? 8192 : Options.InternalBufferSize;

                Watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                    | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                Watcher.Filter = Options.FolderFilter;

                Watcher.Path = Options.FolderPath;

                Watcher.IncludeSubdirectories = Options.FolderIncludeSub;

                Watcher.Changed += new FileSystemEventHandler(OnChanged);

                Watcher.Created += new FileSystemEventHandler(OnCreated);

                Watcher.Deleted += new FileSystemEventHandler(OnDeleted);

                Watcher.Renamed += new RenamedEventHandler(OnRenamed);

                Watcher.Error += new ErrorEventHandler(OnError);

                Watcher.EnableRaisingEvents = Options.FolderEnabled;

                Listening = Options.FolderEnabled;

                slLogger.WriteLogLine("FileShadowWatcher now listening on Directory " + Options.FolderPath);
            }
            catch (Exception ex)
            {
                slLogger.WriteLogLine(ex);
                return false;
            }
            return true;
        }

        //-1 = no Options 0=Everythings fine 1=Error
        internal bool StartInstance(WatcherFactory factory)
        {
            return InitInstance(factory);
        }

        internal bool StartInstance(WatcherFolderOption option, WatcherFactory factory)
        {
            Options = option;
            GUID = option.FolderGUID;
            //snapshotFactory = new SnapshotFactory(backupPath);
            return InitInstance(factory);
        }

        internal void StopInstance()
        {
            Watcher.EnableRaisingEvents = false;
            Listening = false;
            slLogger.WriteLogLine("Watcher on " + Options.FolderPath + " shutdown.");
        }

        internal void ContinueInstance()
        {
            Watcher.EnableRaisingEvents = true;
            Listening = true;
            slLogger.WriteLogLine("Watcher on " + Options.FolderPath + " continued.");
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            WatcherChangeTypes wct = e.ChangeType;
            string FullPath = e.FullPath;
            string Name = e.Name;
            slLogger.WriteLogLine(wct.ToString() + " Path: " + FullPath);
        }

        private void OnCreated(object source, FileSystemEventArgs e)
        {
            WatcherChangeTypes wct = e.ChangeType;
            slLogger.WriteLogLine(wct.ToString() + " Path: " + e.FullPath);
        }
        private void OnDeleted(object source, FileSystemEventArgs e)
        {
            WatcherChangeTypes wct = e.ChangeType;
            string FullPath = e.FullPath;
            string Name = e.Name;
            RestoreDeletedFile(wct, FullPath, Name);
            slLogger.WriteLogLine(wct.ToString() + " Path: " + e.FullPath);
            
            //snapshotFactory.BackupFromShadow(e.FullPath);
        }
        private void OnRenamed(object source, RenamedEventArgs e)
        {
            //  Show that a file has been renamed.
            WatcherChangeTypes wct = e.ChangeType;
            slLogger.WriteLogLine(wct.ToString() + " Old Path: " + e.OldFullPath + " New Path: " + e.FullPath);
        }

        //  This method is called when the FileSystemWatcher detects an error.
        private void OnError(object source, ErrorEventArgs e)
        {
            slLogger.WriteLogLine(e.GetException(),"The FileSystemWatcher has detected an error");
            if (e.GetException().GetType() == typeof(InternalBufferOverflowException))
            {
                //  This can happen if Windows is reporting many file system events quickly 
                //  and internal buffer of the  FileSystemWatcher is not large enough to handle this
                //  rate of events. The InternalBufferOverflowException error informs the application
                //  that some of the file system events are being lost.
                slLogger.WriteLogLine(("The file system watcher experienced an internal buffer overflow: " + e.GetException().Message));
            }
        }

        internal string GetEventFolderName(WatcherFolderOption watcherFolderOption, WatcherFactory.FolderNames folder)
        {
            return watcherFolderOption.TrashFolder + "\\" + folder.ToString();
        }

        internal bool RestoreDeletedFile(WatcherChangeTypes watcherChangeTypes, string FullPath, string Name)
        {
            try
            {
                if (Options.UseForensicsFactory)
                {
                    string FileName = Factory.GetTrashFileName(watcherChangeTypes, Options, Name);
                    Factory.forensicsFactory.RestoreDeletedFile(FullPath, FileName);
                    slLogger.WriteLogLine("Restored deleted file: " + FullPath + " to " + FileName);
                    return true;
                }
            }
            catch (Exception ex)
            {
                slLogger.WriteLogLine(ex, "Could not restore file: " + FullPath);
                return false;
            }
            slLogger.WriteLogLine("ForensicsFactory not in use for file: " + FullPath);
            return false;
        }

        internal bool CopyChangedFile(WatcherChangeTypes watcherChangeTypes, string FullPath, string Name)
        {
            try
            {
                if (Options.UseForensicsFactory)
                {
                    string FileName = Factory.GetTrashFileName(watcherChangeTypes, Options, Name);
                    //Factory.forensicsFactory.RestoreDeletedFile(FullPath, FileName);
                    slLogger.WriteLogLine("Copied changed file: " + FullPath + " to " + FileName);
                    return true;
                }
            }
            catch (Exception ex)
            {
                slLogger.WriteLogLine(ex, "Could not copy file: " + FullPath);
                return false;
            }
            slLogger.WriteLogLine("ForensicsFactory not in use for file: " + FullPath);
            return false;

        }
    }
}
