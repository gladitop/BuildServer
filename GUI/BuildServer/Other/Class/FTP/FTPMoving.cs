using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Xml.Serialization;
using System.Xml;

namespace BuildServer.Other.Class.FTP
{
    public class FTPMoving
    {
        string path = null;

        public FTPMoving(string Path) => path = Path;

        public ServerInfoFTP Export()//Load
        {
            ServerInfoFTP infoFTP;

            XmlSerializer xml = new XmlSerializer(typeof(ServerInfoFTP));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                infoFTP = (ServerInfoFTP)xml.Deserialize(fs);
            }

            return infoFTP;
        }

        public void Import(ServerInfoFTP serverInfoFTP)//Save
        {
            XmlSerializer xml = new XmlSerializer(typeof(ServerInfoFTP));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, serverInfoFTP);

                fs.Close();
            }
        }
    }

    [Serializable]
    public class ServerInfoFTP
    {
        [XmlElement("lol")]
        public int Lol { get; set; }
        [XmlElement("lolKek")]
        public string LOlKek { get; set; }
    }
}