using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShadowWatcherShared
{
    public class ActionList
    {
        public string Name { get; set; }
        public Dictionary<string, string> Arguments { get; set; }
    }
}
