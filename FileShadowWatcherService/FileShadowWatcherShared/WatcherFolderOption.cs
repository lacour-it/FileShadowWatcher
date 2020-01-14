using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShadowWatcherShared
{
    public class WatcherFolderOption
    {
        public WatcherFolderOption()
        {
        }

        public int InternalBufferSize { get; set; }
        /// <summary>Unique identifier of the combination File type/folder.
        /// Arbitrary GUID</summary>
        public string FolderGUID { get; set; }
        /// <summary>If TRUE: the file type and folder will be monitored</summary>
        public bool FolderEnabled { get; set; }
        /// <summary>Description of the type of files and folder location –
        /// Just for documentation purpose</summary>
        public string FolderDescription { get; set; }
        /// <summary>Filter to select the type of files to be monitored.
        /// (Examples: *.shp, *.*, Project00*.zip)</summary>
        public string FolderFilter { get; set; }
        /// <summary>Full path to be monitored
        /// (i.e.: D:\files\projects\shapes\ )</summary>
        public string FolderPath { get; set; }
        /// <summary>If TRUE: the folder and its subfolders will be monitored</summary>
        public bool FolderIncludeSub { get; set; }
        public string TrashFolder { get; set; }
        //use SubFolderNames like Deleted or changed
        public bool UseSubFolderEventNames { get; set; }
        //use the ForensicFactory
        public bool UseForensicsFactory { get; set; }
        //use the actual Date as Folder
        public bool UseDate { get; set; }
        //How many days should the files be kept
        public int DaysToStore { get; set; }
    }
}
