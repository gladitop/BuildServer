using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildServer
{
    static public class Data
    {
        static public object Settings { get; set; }//Class Settings

        //Other

        enum TypeServer
        {
            FTP = 0,
            TCP = 1
        }
    }
}
