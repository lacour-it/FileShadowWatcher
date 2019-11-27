using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alphaleonis.Win32.Filesystem;
using Alphaleonis.Win32.Vss;

namespace FileShadowWatcherShared
{
    public class SnapshotFactory
    {
        public SnapshotFactory(OptionsFactory OptionsFactory)
        {
            optionsFactory = OptionsFactory;
            backupRootDir = optionsFactory.Options.BackupRootPath;
        }

        public SnapshotFactory(string BackupPath)
        {
            backupRootDir = BackupPath;
        }

        OptionsFactory optionsFactory;
        string backupRootDir = "";
        
        public void BackupFromShadow(string sourceFile, string DestinationPath = null)
        {
            using (VssBackup vss = new VssBackup())
            {
                string backupPath = "";
                if (DestinationPath.IsNullOrEmpty())
                {
                    backupPath = Path.Combine(backupRootDir, Path.GetFileName(sourceFile));
                }
                else
                {
                    backupPath = Path.Combine(DestinationPath, Path.GetFileName(sourceFile));
                }

                slLogger.WriteLogLine("Getting VSS-Setup");
                vss.Setup(Path.GetPathRoot(sourceFile));
                slLogger.WriteLogLine("Getting VSS-SnapshotPath");
                string snapPath = vss.GetSnapshotPath(sourceFile);
                slLogger.WriteLogLine("Backup " + sourceFile + " To " + backupPath);
                File.Copy(snapPath, backupPath);
            }
        }
    }
}
