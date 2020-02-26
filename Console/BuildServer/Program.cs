using System;
using FubarDev.FtpServer;

namespace BuildServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BuildServer";
            Desing.ShowIcon();
            //FTP.Start();
            Settings.Open();
            Commands.While();
        }
    }
}