using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

namespace BuildServer.Other.Class.FTP
{
    public class FTPMoving
    {
        string path = null;

        public void Load(string Path) => path = Path;

        public SettingsXmlFtp Export(out SettingsXmlFtp xmlFtp)//Load
        {
            new Thread(() =>
            {
                XmlSerializer xml = new XmlSerializer(typeof(SettingsXmlFtp));

                using (FileStream fs = new FileStream(path + "//Setting.xml", FileMode.OpenOrCreate))
                {
                    SettingsXmlFtp set = (SettingsXmlFtp)xml.Deserialize(fs);
                    xmlFtp = set;
                }
            });
            return new SettingsXmlFtp();
        }

        public void Import(SettingsXmlFtp settings)//Save
        {
            new Thread(() =>
            {
                XmlSerializer xml = new XmlSerializer(typeof(SettingsXmlFtp));

                using (FileStream fs = new FileStream(path + "//Setting.xml", FileMode.OpenOrCreate))
                {
                    xml.Serialize(fs, settings);
                }
            });
        }
    }

    [Serializable]
    public class SettingsXmlFtp
    {
        public List<ServerXmlFtp> serverXmls = new List<ServerXmlFtp>();
    }
    [Serializable]

    public class ServerXmlFtp
    {
        public ServerXmlFtp(Settings.listServer listServer)
        {
            DescriptionServer = listServer.descriptionServer;
            RootNameFolder = listServer.nameServer;
            RootPlaceFolder = listServer.pathServer;
            Passworld = listServer.passworld;
            Ver = listServer.ver;
            PathCertificate = listServer.pathCertificate;
            PassworldCertificate = listServer.passworldCertificate;

            //typeConnect = Settings.TypeConnect.FTP;// !!!

            User = listServer.user;
            MaxConnections = listServer.maxConnections;
            Port = listServer.port;
        }

        public string DescriptionServer { get; set; } = null;
        public string RootNameFolder { get; set; } = null;
        public string RootPlaceFolder { get; set; } = null;
        public string Passworld { get; set; } = null;
        public string Ver { get; set; } = null;
        public string PathCertificate { get; set; } = null;
        public string PassworldCertificate { get; set; } = null;

        public Settings.TypeConnect? TypeConnect { get; set; } = null; //Этот класс только для FTP (но без этого не куда!)

        public string User { get; set; } = null;
        public int MaxConnections { get; set; } = 0;
        public int Port { get; set; } = 0;
    }
}