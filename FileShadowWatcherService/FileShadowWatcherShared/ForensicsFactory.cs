using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerForensics.FileSystems.Ntfs;
using PowerForensics;

namespace FileShadowWatcherShared
{
    public class ForensicsFactory
    {
        //PowerForensics.FileSystems.Ntfs.FileRecord.GetInstances("E:);
        public FileRecord[] GetInstances(string VolumeName)
        {
            FileRecord[] fileRecords = FileRecord.GetInstances(VolumeName);
            return fileRecords;
        }
        public List<FileRecord> GetDeletedInstances(string VolumeName)
        {
            VolumeName = @"\\.\" + VolumeName;
            FileRecord[] fileRecords = FileRecord.GetInstances(VolumeName);
            List<FileRecord> deletedFileRecords = fileRecords.Where(x => x.Deleted).ToList();
            return deletedFileRecords;
        }
        public FileRecord GetDeletedInstance(string FullFileName)
        {
            
            string volumeName = Helper.GetVolumeFromPath(FullFileName);
            FileRecord[] fileRecords = FileRecord.GetInstances(volumeName);
            List<FileRecord> deletedFileRecords = fileRecords.Where(x => x.Deleted).ToList();
            if (deletedFileRecords.Count == 0)
                return null;
            List<FileRecord> deletedFoundFileRecords = deletedFileRecords.Where(x => x.FullName == FullFileName).ToList();
            if (deletedFoundFileRecords.Count == 0)
                return null;
            FileRecord deletedFileRecord = deletedFileRecords.First();
            return deletedFileRecord;
        }

        public string RestoreDeletedFile(string InFullFileName, string OutFullFileName)
        {
            FileRecord fileRecord = GetDeletedInstance(InFullFileName);
            if (fileRecord.IsNull())
                return "Can't restore File, no trace in Master File Table";
            FileRecordAttribute attribute = fileRecord.Attribute.First(a => a.Name == FileRecordAttribute.ATTR_TYPE.DATA);
            if (attribute.IsNull())
                return "Can't find any attribute data to locate the deleted File";
            fileRecord.CopyFile(OutFullFileName);
            return "File copied";
        }
    }
}
