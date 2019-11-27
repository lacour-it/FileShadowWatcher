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
                watcherInstance.StartInstance(item, optionsFactory.Options.BackupRootPath);
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

        public WatcherFolderOption CreateNewWatcherInstance(string FolderPath, bool FolderEnabled = true, string FolderFilter = "*.*", bool IncludeSubDirectories = false, string Description = "New Description")
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
            option.EventExecutables = new List<EventExecutable>();
            return option;
        }

        public WatcherFolderOption CreateNewEventExecutable(WatcherFolderOption Options, WatcherChangeTypes watcherChangeTypes, string ExecutablePath, string ExecutableArgs)
        {
            EventExecutable eventExecutable = new EventExecutable();
            eventExecutable.ExecutableArgs = ExecutableArgs;
            eventExecutable.ExecutablePath = ExecutablePath;
            eventExecutable.WatcherChangeType = watcherChangeTypes;
            Options.EventExecutables.Add(eventExecutable);
            return Options;
        }
    }
}
