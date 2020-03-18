using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions.WriteLine("Loading config...", ConsoleColor.Yellow);
            Settings settings = new Settings("config.bs");
            Data data = settings.Load();

            if (data.Ver != Data.ProgramVer)
            {
                Functions.WriteLine("Error!", ConsoleColor.Red);
                Console.ReadLine();
                Environment.Exit(0);
            }

            Functions.WriteLine("Loading server...", ConsoleColor.Yellow);
            Functions.WriteLine("Done!", ConsoleColor.Green);
        }
    }
}
