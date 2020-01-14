using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileShadowWatcherShared
{
    public class EventExecutable
    {
        public EventExecutable()
        {
            WatcherChangeType = WatcherChangeTypes.All;
        }
        public string WatcherOptionGUID { get; set; }
        public WatcherChangeTypes WatcherChangeType { get; set; }
        public string ExecutablePath { get; set; }
        public string ExecutableArgs { get; set; }
    }
}
