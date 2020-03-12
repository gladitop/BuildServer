using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BuildServer.Other
{
    public class LogManager
    {
        public string path = null;
        object streamWriter = null;

        public void Create(string path)
        {
            StreamWriter wr = new StreamWriter(path);
            wr.AutoFlush = true;
            streamWriter = wr;
        }

        public void WriteLine(string text)
        {
            StreamWriter wr = (StreamWriter)streamWriter;

            wr.WriteLine(text);
        }

        public void Write(string text)
        {
            StreamWriter wr = (StreamWriter)streamWriter;

            wr.Write(text);
        }

        public void Close() 
        {
            StreamWriter wr = (StreamWriter)streamWriter;

            wr.Close();
        }
    }
}
