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

        static public string ver { get; set; } = "1.0";//Версия программы

        //переменные

        static public string RootPlaceFolder { get; set; } = null;//путь сервера
        static public string RootNameFolder { get; set; } = null;//имя сервера
        static public string Port { get; set; } = null;//Порт сервера
        static public string PathCertificate { get; set; } = null;//путь сертификата tls
        static public string PassworldCertificate { get; set; } = null;//пароль сертификата
        static public string DescriptionServer { get; set; } = null;//Описание сервера

        //Прочее

        static public object Settings { get; set; } = null;//Для Settings
    }
}
