using System;
using System.Collections.Generic;
using System.Text;

namespace BuildServer
{
    static public class Desing
    {
        static public void ShowIcon()
        {
            Functions.WriteLine("    d8888b. db    db d888888b db      d8888b. .d8888. d88888b d8888b. db    db d88888b d8888b. ", ConsoleColor.Yellow);
            Functions.WriteLine("    88  `8D 88    88   `88'   88      88  `8D 88'  YP 88'     88  `8D 88    88 88'     88  `8D ", ConsoleColor.Yellow);
            Functions.WriteLine("    88oooY' 88    88    88    88      88   88 `8bo.   88ooooo 88oobY' Y8    8P 88ooooo 88oobY' ", ConsoleColor.Yellow);
            Functions.WriteLine("    88~~~b. 88    88    88    88      88   88   `Y8b. 88~~~~~ 88`8b   `8b  d8' 88~~~~~ 88`8b   ", ConsoleColor.Yellow);
            Functions.WriteLine("    88   8D 88b  d88   .88.   88booo. 88  .8D db   8D 88.     88 `88.  `8bd8'  88.     88 `88. ", ConsoleColor.Yellow);
            Functions.WriteLine("    Y8888P' ~Y8888P' Y888888P Y88888P Y8888D' `8888Y' Y88888P 88   YD    YP    Y88888P 88   YD \n", ConsoleColor.Yellow);
            Functions.WriteLine("This is BuildServer!", ConsoleColor.Yellow);
            Functions.WriteLine($"ver is program: {Data.ver}", ConsoleColor.Yellow);

        }
    }
}
