using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BuildServer
{
    public class Settings
    {
        string FILE;

        public Settings(string file)
        {
            FILE = file;
        }

        public Data Load()
        {
            string[] config = File.ReadAllLines(FILE);
            Data data = new Data();

            data.Ver = config[0];

            if (config[1] == "typeConnect=ftp")
                data.typeConnect = Data.TypeConnect.FTP;
            else if (config[1] == "typeConnect=tcp")
                data.typeConnect = Data.TypeConnect.TCP;

            //port=?
            data.Port = config[2].Substring(5);

            //maxConnections=?
            data.MaxConnections = config[3].Substring(15);

            //сertificate=?
            data.Certificate = Convert.ToBoolean(config[4].Substring(12));

            if (data.Certificate == true)
            {
                //pathCertificate=?
                data.PathCertificate = config[5].Substring(16);

                //passworldCertificate=?
                data.PassworldCertificate = config[6].Substring(21);
            }

            return data;
        }
    }
}