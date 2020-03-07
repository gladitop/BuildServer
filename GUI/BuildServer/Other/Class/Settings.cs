using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        }
    }
}
