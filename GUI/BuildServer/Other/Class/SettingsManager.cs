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
                Settings settings = new Settings();
                {
                    settings.AutoStart = false;
                    settings.NormalStart = true;
                    settings.StartProgram = false;
                    settings.ListServer = new List<Settings.listServer>();
                }
                settings.ListServer.Add(new Settings.listServer()
                {
                    descriptionServer = "des a server!",
                    nameServer = "Test",
                    pathServer = "Tester/user/lol",
                    ver = "1.0"
                });
                settings.ListServer.Add(new Settings.listServer() { descriptionServer = "2 des", nameServer = "Test 2",
                pathServer = "Tester2/lol", ver = "2.0"});

                File.WriteAllText("Settings.json", JsonConvert.SerializeObject(settings));
                Data.Settings = settings;
            }
            else
            {
                Settings settings = Data.Settings;

                File.WriteAllText("Settings.json", JsonConvert.SerializeObject(settings));

                /*
                 * Короче тут баг
                 * после этого бреда пишится null в json
                 */
            }
        }

        static public void Load()
        {
            if (File.Exists("Settings.json"))
            {
                var settings = JsonConvert.DeserializeObject<Settings>("Settings.json");
                Data.Settings = settings;
            }
            else
                Save();
        }
    }
}
