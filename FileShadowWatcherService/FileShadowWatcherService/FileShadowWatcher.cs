using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using FileShadowWatcherShared;

namespace FileShadowWatcherService
{
    public partial class FileShadowWatcher : ServiceBase
    {
        WatcherFactory watcherFactory;
        public FileShadowWatcher()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            watcherFactory = new WatcherFactory();
            watcherFactory.Initialize();
        }

        protected override void OnStop()
        {
            watcherFactory.UnloadAll();
        }
    }
}
