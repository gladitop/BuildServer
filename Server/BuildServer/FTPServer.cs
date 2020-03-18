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
using System.Security.Cryptography.X509Certificates;
using FubarDev.FtpServer.AccountManagement;
using FubarDev.FtpServer.Authentication;
using FubarDev.FtpServer.Authorization;
using FubarDev.FtpServer.ServerCommands;
using FubarDev.FtpServer.Utilities;
using FubarDev.FtpServer.AccountManagement.Anonymous;
using System.Net;

namespace BuildServer
{
    public class FTPServer
    {
        Data DATA;
        IFtpServerHost ftpServer;

        public FTPServer(Data data) => DATA = data;

        public void Start()
        {
            var servis = new ServiceCollection();

            // Add Serilog as logger provider
            //servis.AddLogging(lb => lb.AddSerilog();
            servis.Configure<DotNetFileSystemOptions>(opt => { opt.RootPath = "root"; });
            servis.AddFtpServer(builder => { builder.UseDotNetFileSystem().EnableAnonymousAuthentication(); });
            //servis.ConfigureAll<AnonymousMembershipProvider>(opt => { opt.ValidateUserAsync("123", "123"); });
            servis.ConfigureAll<FtpServerOptions>(opt => { opt.Port = Convert.ToInt32(DATA.Port); 
                opt.ConnectionInactivityCheckInterval = new TimeSpan(0, 0, 10); 
                opt.MaxActiveConnections = Convert.ToInt32(DATA.MaxConnections); });

            servis.Configure<FtpConnectionOptions>(opt => { opt.InactivityTimeout = new TimeSpan(0, 0, 10); });

            // Это нужно простестить! (готово)

            if (DATA.Certificate == true)
            {
                var cert = new X509Certificate2(DATA.PathCertificate, DATA.PassworldCertificate);
                servis.Configure<AuthTlsOptions>(cfg =>
                {
                    cfg.ServerCertificate = cert;
                    cfg.ImplicitFtps = true;
                });
            }
            //

            using (var servisprod = servis.BuildServiceProvider())
            {
                var ftpserverHost = servisprod.GetRequiredService<IFtpServerHost>();
                ftpserverHost.StartAsync(CancellationToken.None).Wait();
                ftpServer = ftpserverHost;
                Console.ReadLine();
                Stop();
            }
        }

        public void Stop()
        {
            ftpServer.StopAsync(CancellationToken.None).Wait();
            Environment.Exit(0);
        }
    }
}
