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
        //public SnapshotFactory snapshotFactory { get; set; }

        private bool InitInstance()
        {
            try
            {
                Watcher = new FileSystemWatcher();

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

                Watcher.EnableRaisingEvents = true;

                Listening = true;

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
        internal bool StartInstance()
        {
            return InitInstance();
        }

        internal bool StartInstance(WatcherFolderOption option, string backupPath)
        {
            Options = option;
            GUID = option.FolderGUID;
            //snapshotFactory = new SnapshotFactory(backupPath);
            return InitInstance();
        }

        internal void StopInstance()
        {
            Watcher.EnableRaisingEvents = false;
            Listening = false;
            slLogger.WriteLogLine("Watcher on " + Options.FolderPath + " shutdown.");
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            WatcherChangeTypes wct = e.ChangeType;
            slLogger.WriteLogLine(wct.ToString() + " Path: " + e.FullPath);
        }

        private void OnCreated(object source, FileSystemEventArgs e)
        {
            WatcherChangeTypes wct = e.ChangeType;
            slLogger.WriteLogLine(wct.ToString() + " Path: " + e.FullPath);
        }
        private void OnDeleted(object source, FileSystemEventArgs e)
        {
            WatcherChangeTypes wct = e.ChangeType;
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
    }
}
