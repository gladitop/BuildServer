using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BuildServer
{
    static public class Settings
    {
        //Переменные для сохранения

        static public string ServerRootPath { get; set; } = null;
        static public string ServerRootName { get; set; } = null;
        static public bool Server { get; set; } = false;

        //Методы для сохранения

        static public void Save()
        {
            using (StreamWriter wr = new StreamWriter("Settings.dll"))
            {
                wr.AutoFlush = true;

                if (Server == false)
                {
                    wr.WriteLine($"Server = {Server}");
                }
                else if (Server == true)
                {
                    wr.WriteLine($"Server = {Server}");
                    wr.WriteLine($"ServerRootPath = {ServerRootPath}");
                    wr.WriteLine($"ServerRootName = {ServerRootName}");
                }

                wr.Close();
            }
        }

        static public void Open()
        {
            /*
            if (File.Exists("Settings.dll"))//Ошибка!
            {
                string[] settingsFile = File.ReadAllLines("Settings.dll");

                if (settingsFile[0] == "Server = False")
                {
                    Server = false;
                    return;
                }
                else if (settingsFile[0] == "Server = True")
                {
                    Server = true;
                    ServerRootPath = settingsFile[1].Substring(18);
                    ServerRootName = settingsFile[2].Substring(18);
                }
            }
            else
                Save();
                */
        }
    }
}
