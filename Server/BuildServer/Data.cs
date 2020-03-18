using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildServer
{
    public class Data
    {
        public string Ver { get; set; }
        public TypeConnect typeConnect { get; set; }
        public string Port { get; set; }
        public string MaxConnections { get; set; }
        public bool Certificate { get; set; }
        public string PathCertificate { get; set; }
        public string PassworldCertificate { get; set; }

        //Other

        public const string ProgramVer = "1.0";

        public enum TypeConnect
        {
            FTP = 0,
            TCP = 1
        }
    }
}
