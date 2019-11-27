using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShadowWatcherShared
{
    public class OptionsList
    {
        public string BackupRootPath { get; set; }
        public List<WatcherFolderOption> WatcherFolderOptions { get; set; }
    }
}
