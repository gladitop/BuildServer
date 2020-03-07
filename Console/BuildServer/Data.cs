using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildServer
{
    static public class Data
    {
        static public string ver { get; set; } = "1.0";
        static public ServiceCollection servic { get; set; } = null;
        static public object settigns { get; set; } = null;
    }
}
