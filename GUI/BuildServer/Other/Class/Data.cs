using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildServer.Other.Class
{
    static public class Data
    {
        //Информация

        static public string ver { get; set; } = "1.0";

        //переменные

        static public string RootPlaceFolder { get; set; } = null;
        static public string RootNameFolder { get; set; } = null;
        static public string Port { get; set; } = null;
        static public string PathCertificate { get; set; } = null;
        static public string PassworldCertificate { get; set; } = null;
        static public string DescriptionServer { get; set; } = null;
        static public object Settings { get; set; } = null;
    }
}
