using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildServer.Other.Class;

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

            Data.Settings = settings;
            SettingsManager.Save();
        }
    }
}
