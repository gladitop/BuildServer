using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace BuildServer.Other.Class.FTP
{
    public class FTPMoving
    {
        string path = null;

        public void Load(string Path) => path = Path;

        public void Export()
        {
            new Thread(() =>
            {
                string[] i = File.ReadAllLines(path);

                int lol = i[0].Length;
            });
        }

        public void Import()
        {
            new Thread(() =>
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("LOl");
                }
            });
        }
    }
}