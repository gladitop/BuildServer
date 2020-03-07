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

        public void Settings()
        {
            
        }
    
        static public void Save()
        {
            if (File.Exists("Settings.json"))
            {
                var _settigs = JsonConvert.DeserializeObject<SettingsForm>("Settings.json");//Нужен нормальный класс!
            }
        }

        static public void Load()
        {
            
        }
    }
}
