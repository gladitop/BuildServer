using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace BuildServer.Other.Class
{
    public class SettingsManager
    { 
        static public void Save()
        {
            if (!File.Exists("Settings.json"))
            {
                var settings = new Settings();
                {
                    settings.AutoStart = false;
                    settings.NormalStart = true;
                    settings.StartProgram = false;
                    settings.ListServer = new List<Settings.listServer>();
                }

                File.WriteAllText("Settings.json", JsonConvert.SerializeObject(settings));
                Data.Settings = settings;
            }
            else
            {
                var settings = (Settings)Data.Settings;

                File.WriteAllText("Settings.json", JsonConvert.SerializeObject(settings));

                /*
                 * Короче тут баг
                 * после этого бреда пишится null в json
                 * Исправлено!
                 */
            }
        }

        static public void Load()
        {
            if (File.Exists("Settings.json"))
            {
                var settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText("Settings.json"));
                Data.Settings = settings;
            }
            else
                Save();
        }
    }
}