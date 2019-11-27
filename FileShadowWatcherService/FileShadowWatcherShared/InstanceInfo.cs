using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShadowWatcherShared
{
    public class InstanceInfo
    {
        public string GUID { get; set; }
        public bool Listening { get; set; }
        public string Folder { get; set; }
        public bool SubFoldersOn { get; set; }
    }
}
