using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using Konsole;

namespace BuildServer
{
    static public class Commands
    {
        static string answer = null;

        static public void While()
        {
            while (true)
            {
                answer = Console.ReadLine();

                if (answer.ToLower() == "exit")
                    Exit();
                else if (answer.ToLower() == "start")
                    StartServer();
                else if (answer.ToLower() == "stop")
                    StopServer();
                else if (answer.ToLower() == "help")
                    Help();
                else if (answer.ToLower() == "credits")
                    CreditsInfo();
                else if (answer.ToLower() == "create ftp")
                    CreateServer();
                else if (answer.ToLower() == "create tcp")
                    CreateServerTCP();
                else if (answer.ToLower() == "delete")
                    DeleteServer();
                else if (answer.ToLower() == "ver")
                    VerInfo();
                else if (answer.ToLower() == "update")
                    Update();
                else
                    Functions.WriteLine("Error! Write help\n", ConsoleColor.Red);
            }
        }

        static public void CreateServerTCP()
        {
            
        }

        static public void Update()
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    web.DownloadProgressChanged += Web_DownloadProgressChanged;
                    var progress = new ProgressBar(PbStyle.DoubleLine, 100);
                }
                catch (Exception ex)
                {
                    Functions.WriteLine($"Error: {ex.Message}\n", ConsoleColor.Red);
                }
            }
        }

        private static void Web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        static public void VerInfo()
        {
            Functions.WriteLine($"Ver {Data.ver}\n", ConsoleColor.Yellow);
        }

        static public void DeleteServer()
        {
            
        }

        static public void CreateServer()
        {
            if (Settings.Server == true)
            {
                Functions.WriteLine("You already have a server!\n", ConsoleColor.Red);
            }
            else if (Settings.Server == false)
            {
                Functions.WriteLine("Are you sure want to create a server? (Y - yes, N - no)",
                    ConsoleColor.Cyan);
                answer = Console.ReadLine();

                if (answer.ToLower() == "y")
                    FTP.CreateServer();
            }
        }

        static public void CreditsInfo()
        {
            
        }

        static public void Help()
        {
            Functions.WriteLine("exit - exit of program", ConsoleColor.Yellow);
            Functions.WriteLine("start - start server", ConsoleColor.Yellow);
            Functions.WriteLine("stop - stop server", ConsoleColor.Yellow);
            Functions.WriteLine("credits - info for credits", ConsoleColor.Yellow);
            Functions.WriteLine("create ftp - create server (ftp)", ConsoleColor.Yellow);
            Functions.WriteLine("create tcp - create server (tcp)", ConsoleColor.Yellow);
            Functions.WriteLine("delete - delete server", ConsoleColor.Yellow);
            Functions.WriteLine("ver - ver the program", ConsoleColor.Yellow);
            Functions.WriteLine("update - update the program\n", ConsoleColor.Yellow);
        }

        static public void StopServer()
        {
            
        }

        static public void StartServer()
        {
            
        }

        static public void Exit()
        {
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Functions.WriteLine($"Shutdown after {i} seconds", ConsoleColor.Red);
            }

            Environment.Exit(0);
        }
    }
}
