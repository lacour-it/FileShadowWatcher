using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileShadowWatcherShared
{
    public class WatcherFactory
    {
        public OptionsFactory optionsFactory = new OptionsFactory();
        public bool IsStarted = false;
        public List<WatcherInstance> WatcherInstances = new List<WatcherInstance>();
        public ForensicsFactory forensicsFactory = new ForensicsFactory();
        public static string ServiceName = "FileShadowWatcher";
        public int TimeOut = 5000;
        public bool ServiceInstalled = false;
        public enum FolderNames
        {
            Changed, Deleted
        }
        public void Initialize()
        {

            optionsFactory.LoadOptions();
            //    return;
            IsStarted = true;
            if (optionsFactory.Options.WatcherFolderOptions.Count == 0)
            {
                CreateFirstInstance();
            }
            InitAllInstances();
        }

        public void InitializeFromGUI()
        {

            optionsFactory.LoadOptions();
            //    return;
            IsStarted = true;
            if (optionsFactory.Options.WatcherFolderOptions.Count == 0)
            {
                CreateFirstInstance();
            }
        }

        private void CreateFirstInstance()
        {
            WatcherFolderOption option = CreateNewWatcherInstance(@"C:\", false);
            optionsFactory.Options.WatcherFolderOptions.Add(option);
            optionsFactory.SaveOptions();
        }

        private void InitAllInstances()
        {
            foreach (WatcherFolderOption item in optionsFactory.Options.WatcherFolderOptions)
            {
                WatcherInstance watcherInstance = new WatcherInstance();
                watcherInstance.StartInstance(item, this);
                WatcherInstances.Add(watcherInstance);
            }
        }

        public void StopInstance(string GUID)
        {
            WatcherInstance instance = WatcherInstances.Find(w => w.GUID == GUID);
            if (!instance.IsNull())
            {
                instance.StopInstance();
            }
        }

        public void StopAllInstances()
        {
            foreach (WatcherInstance item in WatcherInstances)
            {
                item.StopInstance();
            }
        }

        public void ContinueAllInstaces()
        {
            foreach (WatcherInstance item in WatcherInstances)
            {
                if (item.Options.FolderEnabled)
                    item.ContinueInstance();
            }
        }
        public void UnloadAll()
        {
            foreach (WatcherInstance item in WatcherInstances)
            {
                item.Watcher.EnableRaisingEvents = false;
                slLogger.WriteLogLine("Watcher on " + item.Options.FolderPath + " shutdown.");
                item.Watcher.Dispose();
            }
            WatcherInstances.Clear();
            optionsFactory.Options.WatcherFolderOptions.Clear();
        }

        public List<InstanceInfo> GetInstancesInfos()
        {
            List<InstanceInfo> infos = new List<InstanceInfo>();
            foreach (WatcherInstance item in WatcherInstances)
            {
                InstanceInfo info = GetInstancesInfo(item);
                infos.Add(info);
            }
            return infos;
        }

        private InstanceInfo GetInstancesInfo(WatcherInstance instance)
        {
            InstanceInfo info = new InstanceInfo();
            info.GUID = instance.GUID;
            info.Listening = instance.Listening;
            info.SubFoldersOn = instance.Watcher.IncludeSubdirectories;
            info.Folder = instance.Watcher.Path;
            return info;
        }

        public WatcherFolderOption CreateNewWatcherInstance(string FolderPath, bool FolderEnabled = true, string FolderFilter = "*.*", bool IncludeSubDirectories = false, string Description = "New Description", int BufferSize = 8192)
        {
            WatcherFolderOption option = new WatcherFolderOption();
            if (FolderPath.IsNullOrEmpty())
                return null;
            option.FolderGUID = Guid.NewGuid().ToString();
            option.FolderPath = FolderPath;
            option.FolderDescription = Description;
            option.FolderEnabled = FolderEnabled;
            option.FolderFilter = FolderFilter;
            option.FolderIncludeSub = IncludeSubDirectories;
            option.InternalBufferSize = BufferSize;
            option.UseDate = false;
            option.UseForensicsFactory = false;
            option.UseSubFolderEventNames = false;
            option.DaysToStore = 21;
            return option;
        }

        public OptionsList CreateNewEventExecutable(OptionsList Options, string FolderGuid, WatcherChangeTypes watcherChangeTypes, string ExecutablePath, string ExecutableArgs)
        {
            EventExecutable eventExecutable = new EventExecutable();
            eventExecutable.WatcherOptionGUID = FolderGuid;
            eventExecutable.ExecutableArgs = ExecutableArgs;
            eventExecutable.ExecutablePath = ExecutablePath;
            eventExecutable.WatcherChangeType = watcherChangeTypes;
            Options.EventExecutables.Add(eventExecutable);
            return Options;
        }

        public List<EventExecutable> GetEventExecutableByFolderGuid(OptionsList Options, string Guid)
        {
            List<EventExecutable> eventExecutables = new List<EventExecutable>();
            if (Options.EventExecutables.Any(e => e.WatcherOptionGUID == Guid))
            {
                eventExecutables = Options.EventExecutables.Where(e => e.WatcherOptionGUID == Guid).ToList();
            }
            return eventExecutables;
        }

        public void SetupTrashFolder(WatcherFolderOption watcherFolderOption)
        {
            if (!Directory.Exists(watcherFolderOption.TrashFolder))
            {
                try
                {
                    Directory.CreateDirectory(watcherFolderOption.TrashFolder);
                    slLogger.WriteLogLine("Directory " + watcherFolderOption.TrashFolder + " created at " + DateTime.Today.ToShortDateString());
                }
                catch (Exception ex)
                {
                    slLogger.WriteLogLine(ex, "SetupTrashFolderError");
                }
                if (watcherFolderOption.UseSubFolderEventNames)
                {
                    CreateEventFolder(watcherFolderOption, FolderNames.Changed);
                    CreateEventFolder(watcherFolderOption, FolderNames.Deleted);
                }
            }
        }

        internal bool CreateEventFolder(WatcherFolderOption watcherFolderOption, FolderNames folder)
        {
            string folderName = watcherFolderOption.TrashFolder + "\\" + folder.ToString();
            if (!Directory.Exists(folderName))
            {
                try
                {
                    Directory.CreateDirectory(folderName);
                    slLogger.WriteLogLine("Directory " + folderName + " created at " + DateTime.Today.ToShortDateString());
                    return true;
                }
                catch (Exception ex)
                {
                    slLogger.WriteLogLine(ex, "SetupTrashFolderError CreateEventFolderError");
                    return false;
                }
            }
            return false;
        }

        internal string GetRestorePath(WatcherChangeTypes watcherChangeTypes, WatcherFolderOption watcherFolderOption)
        {
            string folderName = String.Empty;
            if (watcherFolderOption.UseSubFolderEventNames)
            {
                switch (watcherChangeTypes)
                {
                    case WatcherChangeTypes.Created:
                        break;
                    case WatcherChangeTypes.Deleted:
                        folderName = watcherFolderOption.TrashFolder + "\\" + FolderNames.Deleted.ToString();
                        break;
                    case WatcherChangeTypes.Changed:
                        folderName = watcherFolderOption.TrashFolder + "\\" + FolderNames.Changed.ToString();
                        break;
                    case WatcherChangeTypes.Renamed:
                        break;
                    case WatcherChangeTypes.All:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                folderName = watcherFolderOption.TrashFolder;
            }
            return folderName;
        }

        internal string GetTrashFileName(WatcherChangeTypes watcherChangeTypes, WatcherFolderOption watcherFolderOption, string FileName)
        {
            string trashFolder = GetRestorePath(watcherChangeTypes, watcherFolderOption);
            string trashFileName = trashFolder + "\\" + FileName;
            if (File.Exists(trashFileName))
            {
                trashFileName = GetFileVersion(trashFileName);
                return trashFileName;
            }
            else
            {
                return trashFileName;
            }
        }

        internal string GetFileVersion(string FileName)
        {
            int max = 1;
            FileInfo fileInfo = new FileInfo(FileName);
            string ext = fileInfo.Extension;
            string folder = fileInfo.Directory.FullName;
            string name = fileInfo.Name.Substring(0, fileInfo.Name.Length - ext.Length - 1);
            string pattern = name + "*." + ext;
            string[] files = Directory.GetFiles(folder, pattern);
            if (files.Length == 1)
                return folder + "\\" + name + "_0001" + "." + ext;
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                string version = info.Name.Substring(name.Length + 1, 4);
                int ver = Int32.Parse(version);
                if (ver == max)
                    max++;
            }
            return folder + " \\_" + name + max.ToString("D4") + "." + ext;
        }

        #region WindowsService

        public bool IsServiceInstalled()
        {
            ServiceInstalled = WindowsServices.IsServiceInstalled(ServiceName);
            return ServiceInstalled;
        }

        public bool IsServiceRunning()
        {
            return WindowsServices.IsServiceRunning(ServiceName);
        }

        public bool IsServicePaused()
        {
            return WindowsServices.IsServicePaused(ServiceName);
        }

        public bool StartService()
        {
            return WindowsServices.StartService(ServiceName, TimeOut);
        }

        public bool StopService()
        {
            return WindowsServices.StopService(ServiceName, TimeOut);
        }

        public bool PauseService()
        {
            return WindowsServices.PauseService(ServiceName, TimeOut);
        }

        public bool ContinueService()
        {
            return WindowsServices.ContinueService(ServiceName, TimeOut);
        }

        public bool ReStartService()
        {
            return WindowsServices.RestartService(ServiceName, TimeOut*2);
        }

        #endregion

    }

}
