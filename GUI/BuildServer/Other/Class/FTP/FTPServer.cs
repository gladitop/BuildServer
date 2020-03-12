using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace BuildServer.Other.Class.FTP
{
    public class FTPServer
    {
        object bufferserverinfo = null;
        object bufferFtpServerHost = null;

        public void LoadServer(string path)//Загрузка переменных из Config.ini
        {
            DataManager.Reset();


        }

        public void Load(Settings.listServer serverinfo) => bufferserverinfo = serverinfo;// Load server info

        public void Start()//Start server
        {
            if (bufferserverinfo == null)
                return;
            var serverinfo = (Settings.listServer)bufferserverinfo;
            var servis = new ServiceCollection();

            // Add Serilog as logger provider
            //servis.AddLogging(lb => lb.AddSerilog();
            servis.Configure<DotNetFileSystemOptions>(opt => { opt.RootPath = serverinfo.pathServer
                +"//"+serverinfo.nameServer; });
            servis.AddFtpServer(builder => { builder.UseDotNetFileSystem().EnableAnonymousAuthentication(); });
            //servis.ConfigureAll<AnonymousMembershipProvider>(opt => { opt.ValidateUserAsync("123", "123"); });
            servis.ConfigureAll<FtpServerOptions>(opt => { opt.Port = serverinfo.port;
                opt.ConnectionInactivityCheckInterval = new TimeSpan(0, 0, 10); 
                opt.MaxActiveConnections = serverinfo.maxConnections; });

            servis.Configure<FtpConnectionOptions>(opt => { opt.InactivityTimeout = new TimeSpan(0, 0, 10); });

            // Это нужно простестить! (готово)

            var cert = new X509Certificate2(serverinfo.pathCertificate, serverinfo.passworldCertificate);
            servis.Configure<AuthTlsOptions>(cfg => {
                cfg.ServerCertificate = cert;
                cfg.ImplicitFtps = true;
            });
            //

            using (var servisprod = servis.BuildServiceProvider())
            {
                var ftpserverHost = servisprod.GetRequiredService<IFtpServerHost>();
                ftpserverHost.StartAsync(CancellationToken.None).Wait();
                bufferFtpServerHost = ftpserverHost;
            }

        }

        public void Stop()//Stop server
        {
            if (bufferserverinfo == null)
                return;
            var ftpserverHost = (IFtpServerHost)bufferFtpServerHost;

            ftpserverHost.StopAsync(CancellationToken.None).Wait();
        }
    }
}
