using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace BuildServer
{
    public class Settings
    {
        //Переменные для сохранения

        [JsonProperty("serverRootName")]
        public string ServerRootName { get; set; } = null;
        [JsonProperty("server")]
        public bool Server { get; set; }
    }

    static public class SettingsMes
    {
        static public void Save()
        {
            if (File.Exists("Setings.json") == false)
            { 
                var settings = new Settings();
                {
                    settings.Server = false;
                    settings.ServerRootName = "";
                }

                File.WriteAllText("Settings.json", JsonConvert.SerializeObject(settings));
                Data.settigns = settings;
            }
            else
            {
                var settings = Data.settigns;

                File.WriteAllText("Settings.json", JsonConvert.SerializeObject(settings));
            }
        }

        static public void Load()
        {
            var settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText("Settings.json"));
            Data.settigns = settings;
        }
    }
}
