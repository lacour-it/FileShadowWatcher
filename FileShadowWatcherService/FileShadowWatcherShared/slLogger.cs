using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Reflection;
using System.IO;

namespace FileShadowWatcherShared
{
    /// <summary>
    /// Schreibt Informationen des Programmablaufs in eine Log-Datei
    /// </summary>
    public class slLogger
    {

        private string myLogfileName = "";

        public string LogfileName
        {
            get { return myLogfileName; }
            set { myLogfileName = value; }
        }


        /// <summary>
        /// Liefert den Pfad der zum Programm gehörigen Log-Datei ab. Existiert dieser nicht, wird er erstellt.
        /// </summary>
        /// <returns></returns>
        private static string GetLogFile()
        {
            string LogFile = "";
            AssemblyName progName = Assembly.GetEntryAssembly().GetName();
            LogFile = Extensions.GetCommonApplicationDataFolder(true) + "\\" + progName.Name + ".log";
            return LogFile;
        }


        public static string ReadLogFile()
        {
            string logFile = "";
            string logPath = GetLogFile();
            if (File.Exists(logPath))
            {
                logFile = File.ReadAllText(logPath, Encoding.UTF8);
            }
            return logFile;
        }

        public static string ReadLogFile(string assembylName)
        {
            string logFile = "";
            string logPath = Extensions.GetCommonApplicationDataFolder(true) + "\\" + assembylName + ".log";
            if (File.Exists(logPath))
            {
                logFile = File.ReadAllText(logPath, Encoding.UTF8);
            }
            return logFile;
        }

        /// <summary>
        /// Schreibt einen String als Zeile in die Log-Datei
        /// </summary>
        /// <param name="Entry"></param>
        public static void WriteLogLine(string Entry)
        {
            StreamWriter myWriter = new StreamWriter(GetLogFile(), true, Encoding.UTF8);
            myWriter.WriteLine(DateTime.Now.ToString() + ((char)9).ToString() + Entry);
            myWriter.Close();
        }

        /// <summary>
        /// Schreibt die Message einer Exception als Zeile in die Log-Datei
        /// </summary>
        /// <param name="ex"></param>
        public static void WriteLogLine(Exception ex)
        {
            StreamWriter myWriter = new StreamWriter(GetLogFile(), true, Encoding.UTF8);
            string tg = "Keine Angabe";
            string sr = "Keine Angabe";
            if (ex.TargetSite != null)
                tg = ex.TargetSite.Name;
            if (ex.Source != null)
                sr = ex.Source;
            string Logline = DateTime.Now.ToString() + ((char)9).ToString() +
                tg + ((char)9).ToString() + ex.Message + ((char)9).ToString() +
                sr + ((char)9).ToString();
            foreach (DictionaryEntry myInfo in ex.Data)
            {
                string info = myInfo.Key.ToString() + ((char)9).ToString() + myInfo.Value.ToString();
                Logline = Logline + info;
            }
            myWriter.WriteLine(Logline);
            myWriter.Close();
        }

        /// <summary>
        /// Schreibt die Message einer Exception als Zeile in die Log-Datei und einen Zusatz-String
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="Zusatz"></param>
        public static void WriteLogLine(Exception ex, string Zusatz)
        {
            StreamWriter myWriter = new StreamWriter(GetLogFile(), true, Encoding.UTF8);
            string tg = "Keine Angabe";
            string sr = "Keine Angabe";
            if (ex.TargetSite != null)
                tg = ex.TargetSite.Name;
            if (ex.Source != null)
                sr = ex.Source;
            string Logline = DateTime.Now.ToString() + ((char)9).ToString() +
                tg + ((char)9).ToString() + ex.Message + ((char)9).ToString() +
                sr + ((char)9).ToString();
            foreach (DictionaryEntry myInfo in ex.Data)
            {
                string info = myInfo.Key.ToString() + ((char)9).ToString() + myInfo.Value.ToString();
                Logline = Logline + info;
            }
            Logline = Logline + ((char)9).ToString() + Zusatz;
            myWriter.WriteLine(Logline);
            myWriter.Close();
        }

        /// <summary>
        /// Ermittelt die Größe einer Log-Datei
        /// </summary>
        /// <returns></returns>
        public static int GetSizeInfo()
        {
            int size = 0;
            string name = GetLogFile();
            if (File.Exists(name))
                size = File.ReadAllBytes(name).Length;
            return size;
        }

        /// <summary>
        /// Löscht Zeilen aus der LogDatei
        /// </summary>
        public static void DeleteLines()
        {
            if (GetSizeInfo() > 1000000)
            {
                StreamReader myReader = new StreamReader(GetLogFile(), Encoding.UTF8);
                int LineCount = 0;
                while (!myReader.EndOfStream)
                {
                    string a = myReader.ReadLine();
                    LineCount = LineCount + 1;
                }
                myReader.Close();
                myReader = new StreamReader(GetLogFile(), Encoding.UTF8);
                LineCount = 0;
                string WriteNew = "";
                while (!myReader.EndOfStream)
                {
                    string a = myReader.ReadLine();
                    LineCount = LineCount + 1;
                    if (LineCount > 2000)
                        WriteNew = WriteNew + a;
                }
                myReader.Close();
                StreamWriter myWriter = new StreamWriter(GetLogFile(), false, Encoding.UTF8);
                myWriter.Write(WriteNew);
                myWriter.Close();
            }
        }
    }
}

