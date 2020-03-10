using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildServer.Other.Class.FTP
{
    static public class FTPServer
    {
        //переменные

        static public List<string> ListServer = new List<string>();

        static public void LoadServer()//Загрузка переменных из Config.ini
        {
            DataManager.Reset();


        }

        static public void Start(string path)//старт
        {
            
        }

        static public void Stop(string path)//стоп
        {
            
        }
    }
}
