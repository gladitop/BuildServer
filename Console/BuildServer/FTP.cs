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
//Нужно больше библиотек!

namespace BuildServer
{
    static public class FTP
    {
        static public void Start()
        {
            /* 1 */
            var servis = new ServiceCollection();

            servis.Configure<DotNetFileSystemOptions>(opt => { opt.RootPath = "Test"; });
            //servis.AddFtpServer(builder => { builder.UseDotNetFileSystem().EnableAnonymousAuthentication(); });
            servis.AddFtpServer(builder => { builder.UseDotNetFileSystem(); });
            //servis.Configure<FtpServerOptions>(opt => { opt.ServerAddress = "127.0.0.1"; opt.Port = 987; opt.MaxActiveConnections = 10; });
            servis.ConfigureAll<FtpServerOptions>(opt => { opt.Port = 987; opt.ConnectionInactivityCheckInterval = new TimeSpan(0, 0, 10); opt.MaxActiveConnections = 10; });
            //servis.PostConfigureAll<PostConfigureOptions<AuthTlsOptions>>(opt => { opt.});

            servis.Configure<FtpConnectionOptions>(opt => { opt.InactivityTimeout = new TimeSpan(0, 0, 10); });
            //servis.ConfigureAll<IMembershipProvider>(opt => { opt. });
            //servis.ConfigureAll<IAnonymousFtpUser>(opt => { opt.Name = "GLadi"; });
            //servis.ConfigureAll<AuthenticationMechanism>(opt => { opt.});
            //servis.ConfigureAll<FtpLoginStateMachine>(opt => { opt.});
            //servis.ConfigureAll<FubarDev.FtpServer.Authorization.PasswordAuthorization>(opt => { )});
            //IFtpConnection lol;
            //servis.PostConfigureAll<PasswordAuthorization>(o => { lol = o.Connection; });
            //servis.ConfigureAll<FtpCommand>(opt => { });
            //servis.ConfigureAll<FtpConnection>(opt => { opt.});
            //servis.ConfigureAll<AnonymousFtpUser>(opt => { opt.});
            //servis.ConfigureAll<FubarDev.FtpServer.Utilities.DirectoryListingEnumerator>(opt => opt.);
            // Это нужно простестить! (готово)
            //servis.ConfigureAll<FubarDev.FtpServer.Authorization.PasswordAuthorization>(opt => { IFtpConnection lol = opt.Connection; lol.});
            //servis.ConfigureAll<AuthorizationRam>
            servis.ConfigureAll<IMembershipProvider>( opt => { opt.ValidateUserAsync("Gladi", "12345").Start(); });
            servis.ConfigureAll<SimpleMailAddressValidation>(opt => { opt.IsValid("12345"); });

            var cert = new X509Certificate2("ssl.pfx", "9382034");
            servis.Configure<AuthTlsOptions>(cfg => {
                cfg.ServerCertificate = cert;
                cfg.ImplicitFtps = true;
            });
            //

            servis.AddOptions();
            using (var servisprod = servis.BuildServiceProvider())
            { 
                var ftpserverHost = servisprod.GetRequiredService<IFtpServerHost>();
                ftpserverHost.StartAsync(CancellationToken.None).Wait();
                Console.ReadLine();
                ftpserverHost.StopAsync(CancellationToken.None).Wait();
            }
            

            /* 2

            // This example requires the Chilkat API to have been previously unlocked.
            // See Global Unlock Sample for sample code.

            Chilkat.Ftp2 ftp = new Chilkat.Ftp2();
            

            // If this example does not work, try using passive mode
            // by setting this to true.
            ftp.Passive = true;

            ftp.Hostname = "127.0.0.1";
            //ftp.Username = "Gladi";
            //ftp.Port = 987;
            //ftp.Password = "test";

            // Establish an AUTH TLS secure channel after connection
            // on the standard FTP port 21.
            //ftp.AuthTls = true;

            // The Ssl property is for establishing an implicit SSL connection
            // on port 990.  Do not set it.
            //ftp.Ssl = false;

            // Connect and login to the FTP server.
            
            //if (success != true)
            //{
            //    Console.WriteLine(ftp.LastErrorText);
            //    //return;
            //}
            //else
            //{
            //    // LastErrorText contains information even when
            //    // successful. This allows you to visually verify
            //    // that the secure connection actually occurred.
            //    Console.WriteLine(ftp.LastErrorText);
            //}

            Console.WriteLine("Secure FTP Channel Established!");

            // Do whatever you're doing to do ...
            // upload files, download files, etc...

            //success = ftp.Disconnect();
            Console.ReadLine();
            */
        }

        static public void Stop()
        {
            
        }
    }
}
