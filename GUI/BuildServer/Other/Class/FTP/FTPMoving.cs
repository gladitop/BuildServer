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

        public FTPMoving(string Path) => path = Path;

        public SettingsXmlFtp Export()//Load
        {
            SettingsXmlFtp set = new SettingsXmlFtp(new Settings.listServer());
            XmlSerializer xml = new XmlSerializer(typeof(SettingsXmlFtp));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                set = (SettingsXmlFtp)xml.Deserialize(fs);
            }

            return set;// Лол! Я исправил баг!
        }

        public void Import(SettingsXmlFtp settings)//Save
        {
            XmlSerializer xml = new XmlSerializer(typeof(SettingsXmlFtp));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, settings); // тут баг!
                //он не имеет беспараметрического конструктора
            }
        }
    }

    [Serializable]
    public class SettingsXmlFtp
    {
        //[XmlArray("serverXmlsList")]
        //public List<ServerXmlFtp> serverXmls = new List<ServerXmlFtp>();
        //public int lol { get; set; } = 0;

        public SettingsXmlFtp(Settings.listServer listServer)
        {
            DescriptionServer = listServer.descriptionServer;
            RootNameFolder = listServer.nameServer;
            RootPlaceFolder = listServer.pathServer;
            Passworld = listServer.passworld;
            Ver = listServer.ver;
            PathCertificate = listServer.pathCertificate;
            PassworldCertificate = listServer.passworldCertificate;

            TypeConnect = Settings.TypeConnect.FTP;// !!!

            User = listServer.user;
            MaxConnections = listServer.maxConnections;
            Port = listServer.port;
        }

        [XmlElement("descriptionServer")]
        public string DescriptionServer { get; set; } = null;

        [XmlElement("rootNameFolder")]
        public string RootNameFolder { get; set; } = null;

        [XmlElement("rootPlaceFolder")]
        public string RootPlaceFolder { get; set; } = null;

        [XmlElement("passworld")]
        public string Passworld { get; set; } = null;

        [XmlElement("ver")]
        public string Ver { get; set; } = null;

        [XmlElement("pathCertificate")]
        public string PathCertificate { get; set; } = null;

        [XmlElement("passworldCertificate")]
        public string PassworldCertificate { get; set; } = null;

        [XmlElement("typeConnect")]
        public Settings.TypeConnect? TypeConnect { get; set; } = null; //Этот класс только для FTP (но без этого не куда!)

        [XmlElement("user")]
        public string User { get; set; } = null;

        [XmlElement("maxConnections")]
        public int MaxConnections { get; set; } = 0;

        [XmlElement("port")]
        public int Port { get; set; } = 0;
    }
    [Serializable]

    public class ServerXmlFtp
    {
        //public ServerXmlFtp(Settings.listServer listServer)
        //{
        //    DescriptionServer = listServer.descriptionServer;
        //    RootNameFolder = listServer.nameServer;
        //    RootPlaceFolder = listServer.pathServer;
        //    Passworld = listServer.passworld;
        //    Ver = listServer.ver;
        //    PathCertificate = listServer.pathCertificate;
        //    PassworldCertificate = listServer.passworldCertificate;

        //    //typeConnect = Settings.TypeConnect.FTP;// !!!

        //    User = listServer.user;
        //    MaxConnections = listServer.maxConnections;
        //    Port = listServer.port;
        //}
    }
}