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
            Data.MaxConnections = 10;

            settings.ListServer.Add(new Settings.listServer()
            {
                descriptionServer = Data.DescriptionServer,
                nameServer = Data.RootNameFolder,
                pathServer = Data.RootPlaceFolder,
                passworld = null,
                ver = Data.ver,
                pathCertificate = Data.PathCertificate,
                passworldCertificate = Data.PassworldCertificate,
                typeConnect = Settings.TypeConnect.FTP,
                user = null,
                maxConnections = Data.MaxConnections,
                port = Convert.ToInt32(Data.Port)
            });

            Directory.CreateDirectory(Data.RootPlaceFolder);
            Directory.CreateDirectory($"{Data.RootPlaceFolder}/{Data.RootNameFolder}");
            Directory.CreateDirectory($"{Data.RootPlaceFolder}/{Data.RootNameFolder}/root");
            //File.Create($"{Data.RootPlaceFolder}/{Data.RootNameFolder}/Config.ini");

            using (StreamWriter sw = new StreamWriter($"{Data.RootPlaceFolder}/{Data.RootNameFolder}/config.bs"))
            {
                sw.AutoFlush = true;

                sw.WriteLine(Data.ver);

                if (Data.TypeConnect == Settings.TypeConnect.FTP)
                    sw.WriteLine("typeConnect=ftp");
                else if (Data.TypeConnect == Settings.TypeConnect.TCP)
                    sw.WriteLine("typeConnect=tcp");

                sw.WriteLine($"port={Data.Port}");
                sw.WriteLine($"maxConnections={Data.MaxConnections}");

                if (Data.PathCertificate == null || Data.PathCertificate == "")
                    sw.WriteLine($"certificate={bool.TrueString}");

                sw.WriteLine($"pathCertificate={Data.PathCertificate}");
                sw.WriteLine($"passworldCertificate={Data.PassworldCertificate}");

                sw.Close();
            }
            

            Data.Settings = settings;
            SettingsManager.Save();
        }
    }
}
