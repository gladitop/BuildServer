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
        [JsonProperty("startProgram")]
        static public bool StartProgram { get; set; }
        [JsonProperty("autoStart")]
        static public bool AutoStart { get; set; }
        [JsonProperty("normalStart")]
        static public bool NormalStart { get; set; }
    }
}
