using System;
using System.Collections.Generic;

namespace FileShadowWatcherShared
{
    public class OptionsFactory
    {
        public OptionsList Options { get; set; }
        public string OptionsPath { get; set; }

        public OptionsFactory()
        {
            OptionsPath = Extensions.GetCommonApplicationDataFolder(true) + "\\WatcherOptions.xml";
            Options = new OptionsList();
            Options.WatcherFolderOptions = new List<WatcherFolderOption>();
            Options.EventExecutables = new List<EventExecutable>();
        }
        public bool LoadOptions()
        {
            try
            {
                Options = (OptionsList)Extensions.LoadFromXML(Options, OptionsPath);
            }
            catch (Exception ex)
            {
                slLogger.WriteLogLine(ex);
            }
            if (!Options.IsNull())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SaveOptions()
        {
            Extensions.SaveToXML(Options, OptionsPath);
        }
    }
}
