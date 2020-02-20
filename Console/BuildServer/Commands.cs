using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BuildServer
{
    static public class Commands
    {
        static string answer = null;

        static public void While()
        {
            while (true)
            {
                answer = Console.ReadLine();

                if (answer.ToLower() == "exit")
                    Exit();
                else
                    Functions.WriteLine("Error!\n", ConsoleColor.Red);
            }
        }

        static public void Exit()
        {
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Functions.WriteLine($"Shutdown after {i} seconds", ConsoleColor.Red);
            }

            Environment.Exit(0);
        }
    }
}
