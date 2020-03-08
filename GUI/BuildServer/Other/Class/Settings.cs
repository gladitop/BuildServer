using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace BuildServer.Other.Class
{
    public class Settings
    {
        //переменные для сохранения

        [JsonProperty("startProgram")]
        public bool StartProgram { get; set; }
        [JsonProperty("autoStart")]
        public bool AutoStart { get; set; }
        [JsonProperty("normalStart")]
        public bool NormalStart { get; set; }
        [JsonProperty("listServer")]
        public List<listServer> ListServer { get; set; } = new List<listServer>();

        //Прочее

        public struct listServer
        {
            public string nameServer;
            public string ver;
            public string pathServer;
            public string descriptionServer;
            public string typeConnect;
            public string user;
            public string passworld;
        }
    }

    public class SettingsManager
    {
        static public void Save()
        {
            if (File.Exists("Settings.json") == false)
            {
                var settings = new Settings();
                {
                    settings.AutoStart = false;
                    settings.NormalStart = true;
                    settings.StartProgram = false;
                    settings.ListServer = new List<Settings.listServer>();
                }
                settings.ListServer.Add(new Settings.listServer() { descriptionServer="This test server",
                nameServer="TestServer", passworld="123", pathServer= @"C:\BuildServer\GUI\BuildServer\bin\Debug",
                typeConnect="tcp",user="Gladi",ver="1.0"});

                File.WriteAllText("Settings.json", JsonConvert.SerializeObject(settings));
                Data.Settings = settings;
            }
            else
            {
                var set = (Settings)Data.Settings;
                var settings = (Settings)Data.Settings;
                {
                    settings.StartProgram = set.StartProgram;
                    settings.NormalStart = set.NormalStart;
                    settings.ListServer = set.ListServer;
                    settings.AutoStart = set.AutoStart;
                }

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
