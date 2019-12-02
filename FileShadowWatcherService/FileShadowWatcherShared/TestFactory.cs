using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alphaleonis.Win32.Vss;
using Alphaleonis.Win32.Filesystem;
using PowerForensics.BootSectors;

namespace FileShadowWatcherShared
{
    public class TestFactory
    {
        public static void InitializeVSS()
        {
            using (VssBackup vss = new VssBackup())
            {
                string backupPath = @"F:\";
                string sourceFile = @"E:\Daten\Doku\DokuMandandtassistent.docx";
                vss.Setup(Path.GetPathRoot(sourceFile));
                slLogger.WriteLogLine("Getting VSS-SnapshotPath");
                string snapPath = vss.GetSnapshotPath(sourceFile);
                slLogger.WriteLogLine("Backup " + sourceFile + " To " + backupPath);
                File.Copy(snapPath, backupPath);
            }

        }

        public static void TestForensic()
        {
            //PowerForensics.BootSectors.GuidPartitionTable guidPartitionTable = new GuidPartitionTable();
            //guidPartitionTable.
        }
    }
}
