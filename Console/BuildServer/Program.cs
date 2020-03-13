using System;
using FubarDev.FtpServer;
using BuildServer;

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
            Settings.Load();
            var settings = (BuildServer.Settings)Data.Settings;
            Console.WriteLine(settings.Server);
            Console.WriteLine(settings.ServerRootName);
        }
    }
}