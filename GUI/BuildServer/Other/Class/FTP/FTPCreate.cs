using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildServer.Other.Class;
using System.IO;

namespace BuildServer.Other.Class.FTP
{
    static public class FTPCreate
    {
        static public void Create()
        {
            var settings = (Settings)Data.Settings;

            settings.ListServer.Add(new Settings.listServer() { descriptionServer = Data.DescriptionServer,
            nameServer = Data.RootNameFolder, pathServer = Data.RootPlaceFolder, passworld=null, ver=Data.ver,
            pathCertificate = Data.PathCertificate, passworldCertificate = Data.PassworldCertificate, typeConnect="ftp",
            user=null});

            Directory.CreateDirectory(Data.RootPlaceFolder);
            Directory.CreateDirectory($"{Data.RootPlaceFolder}/{Data.RootNameFolder}");
            Directory.CreateDirectory($"{Data.RootPlaceFolder}/{Data.RootNameFolder}/root");
            File.Create($"{Data.RootPlaceFolder}/{Data.RootNameFolder}/Config.ini");

            using (StreamWriter sw = new StreamWriter($"{Data.RootPlaceFolder}/{Data.RootNameFolder}/Config.ini"))
            {
                sw.AutoFlush = true;

                sw.WriteLine(Data.DescriptionServer);
                sw.WriteLine(Data.RootNameFolder);
                sw.WriteLine(Data.RootPlaceFolder);
                sw.WriteLine("");//passworld
                sw.WriteLine(Data.ver);
                sw.WriteLine(Data.PathCertificate);
                sw.WriteLine(Data.PassworldCertificate);
                sw.WriteLine("ftp");
                sw.WriteLine("");//user

                sw.Close();
            }

            Data.Settings = settings;
            SettingsManager.Save();
        }
    }
}
