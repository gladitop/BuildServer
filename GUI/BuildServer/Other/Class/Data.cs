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
        static public int MaxConnections { get; set; } = 0;//Максимально подключений
        static public Settings.TypeConnect TypeConnect { get; set; } = 0;//Тип подключения
        static public string User { get; set; } = null;//Это пользователь сервера
        static public string Passworld { get; set; } = null;//Это пароль сервера
        static public bool ServerIsLive { get; set; } = false;//Сервер работает?

        //Прочее

        static public object Settings { get; set; } = null;//Для Settings
    }

    static public class DataManager//Тут разные методы для Data
    {
        static public void Reset()//Сброс данных
        {
            Data.RootPlaceFolder = "";
            Data.RootNameFolder = "";
            Data.Port = "";
            Data.PathCertificate = "";
            Data.PassworldCertificate = "";
            Data.DescriptionServer = "";
            Data.MaxConnections = 0;
            Data.ServerIsLive = false;
            Data.TypeConnect = Settings.TypeConnect.FTP;
            Data.User = null;
            Data.Passworld = null;
        }
    }
}
