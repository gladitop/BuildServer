using System;
using System.Collections.Generic;
using System.Text;
using FubarDev.FtpServer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyModel;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using FubarDev.FtpServer.FileSystem.DotNet;
using System.IO;
using System.Threading;

namespace BuildServer
{
    static public class FTP
    {
        static public void Start()
        {
            var servis = new ServiceCollection();

            servis.Configure<DotNetFileSystemOptions>(opt => opt.RootPath = Path.Combine(Path.GetTempPath(), "Tets"));
            servis.AddFtpServer(builder => builder.UseDotNetFileSystem().EnableAnonymousAuthentication());

            servis.Configure<FtpServerOptions>(opt => opt.ServerAddress = "127.0.0.1");

            using (var servisprod = servis.BuildServiceProvider())
            {
                var ftpserverHost = servisprod.GetRequiredService<IFtpServerHost>();
                ftpserverHost.StartAsync(CancellationToken.None).Wait();
                Console.ReadLine();
                ftpserverHost.StopAsync(CancellationToken.None).Wait();
            }
        }

        static public void Stop()
        {
            
        }
    }
}
