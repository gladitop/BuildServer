using System;
using FubarDev.FtpServer;

namespace BuildServer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Title = "BuildServer";
            Desing.ShowIcon();
            //FTP.Start();
            Settings.Open();
            Commands.While();
            */
            //SettingsMes.Save();
            SettingsMes.Load();
            Settings settings = (Settings)Data.settigns;
            Console.WriteLine(settings.Server);
            Console.WriteLine(settings.ServerRootName);
        }
    }
}