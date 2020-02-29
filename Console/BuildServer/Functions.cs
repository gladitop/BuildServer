using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BuildServer
{
    static public class Functions
    {
        static public void WriteLog(string text, ConsoleColor color)//ещё не готово!
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{DateTime.Now}: {text}");
            
            Console.ResetColor();
        }

        static public void WriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static public void Write(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
