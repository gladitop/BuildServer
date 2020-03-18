using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FubarDev.FtpServer;
using BuildServer.Other.Class;

namespace BuildServer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        object bufferserverinfo;
        object bufferserver;

        public MainWindow()
        {
            InitializeComponent();

            //SettingsManager.Load();
            //SettingsManager.Save();
            //Other.Class.SettingsManager.Load();
            //var settings = (Settings)Data.Settings;
            //settings.ListServer.Add(new Settings.listServer() { descriptionServer = "2 des", nameServer = "Test 2",
            //pathServer = "Tester2/lol", ver = "2.0", user="Gladi", typeConnect=Settings.TypeConnect.FTP, maxConnections = 10,
            //passworld = "123456789", passworldCertificate="547345", pathCertificate="Я не знаю", port = 987});
            //Data.Settings = settings;
            //SettingsManager.Save();

            LoadingListServer();

            /*
            Other.Class.FTP.ServerXmlFtp settings = 
                new Other.Class.FTP.ServerXmlFtp( (Settings.listServer)bufferserverinfo );
            Other.Class.FTP.SettingsXmlFtp xmlFtp = new Other.Class.FTP.SettingsXmlFtp();
            xmlFtp.serverXmls.Add(settings);
            Other.Class.FTP.FTPMoving ftpMoving = new Other.Class.FTP.FTPMoving("");

            ftpMoving.Import(xmlFtp);
            */
        }

        public void LoadingListServer()
        {
            var set = (Settings)Data.Settings;
            listserver.Items.Clear();

            foreach (var listservername in set.ListServer)
            {
                listserver.Items.Add(listservername.nameServer);
            }
        }

        private void btaddserver_Click(object sender, RoutedEventArgs e)//Add server
        {
            AddServer addServer = new AddServer();
            addServer.ShowDialog();

            LoadingListServer();
        }

        private void btdeleteserver_Click(object sender, RoutedEventArgs e)//Delete server
        {
            if (!Data.ServerIsLive)
            {
                if (bufferserverinfo == null)
                    return;

                var serverinfo = (Settings.listServer)bufferserverinfo;
                MessageBoxResult i = MessageBox.Show("Вы точно хотите удалить этот сервер?", Title,
                    MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (i == MessageBoxResult.Yes)
                {
                    Data.PathServerDelete = serverinfo.pathServer + "//" + serverinfo.nameServer;

                    BuildServer.Other.Windows.DeleteServer deleteServer = new Other.Windows.DeleteServer();
                    deleteServer.ShowDialog();

                    LoadingListServer();
                }
            }
            else
                MessageBox.Show("Отключите сервер!", Title, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)//Close
        {
            if (Data.ServerIsLive)
            {
                MessageBoxResult i = MessageBox.Show("Сейчас работает сервер! Завершить работу?", Title, MessageBoxButton.YesNo,
                    MessageBoxImage.Warning);

                if (i == MessageBoxResult.No)
                    e.Cancel = true;
                else
                {
                    
                }
            }
            Environment.Exit(0);
        }

        private void btssettings_Click(object sender, RoutedEventArgs e)//settings
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void listserver_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listserver.SelectedItem == null)
                return;
            var set = (Settings)Data.Settings;
            object buffer = null;

            lbnameserver.Content = "Name: " + listserver.SelectedItem.ToString();

            foreach (object serverlistname in set.ListServer)
            {
                var lol = (Settings.listServer)serverlistname;

                if (lol.nameServer == listserver.SelectedItem.ToString())
                    buffer = serverlistname;
            }

            var serverinfo = (Settings.listServer)buffer;
            lbtypeConnectserver.Content = $"Type connect: {serverinfo.typeConnect}";
            lbpathCertificateserver.Content = $"Path certificate: {serverinfo.pathCertificate}";
            lbpathserver.Content = $"Path server: {serverinfo.pathServer}";

            bufferserverinfo = serverinfo;

            /*
            Other.Class.FTP.FTPMoving moving = new Other.Class.FTP.FTPMoving("Settings.xml");
            Other.Class.FTP.ServerInfoFTP serverInfoFTP = new Other.Class.FTP.ServerInfoFTP();

            serverInfoFTP = moving.Export();
            serverInfoFTP.Lol++;
            serverInfoFTP.LOlKek = "123";
            moving.Import(serverInfoFTP);
            */
        }

        private void btlbpathCertificateserver_Click(object sender, RoutedEventArgs e)
        {
            if (bufferserverinfo == null)
                return;

            var serverinfo = (Settings.listServer)bufferserverinfo;
            MessageBox.Show($"Path certificate: {serverinfo.pathCertificate}", Title,
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btlbpathserver_Click(object sender, RoutedEventArgs e)
        {
            if (bufferserverinfo == null)
                return;

            var serverinfo = (Settings.listServer)bufferserverinfo;
            MessageBox.Show($"Path server: {serverinfo.pathServer}", Title,
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btopendescriptionserver_Click(object sender, RoutedEventArgs e)
        {
            if (bufferserverinfo == null)
                return;

            var serverinfo = (Settings.listServer)bufferserverinfo;
            MessageBox.Show(serverinfo.descriptionServer, Title,
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btstartserver_Click(object sender, RoutedEventArgs e)// start/stop server
        {
            if (bufferserverinfo == null)
                return;

            if (!Data.ServerIsLive)
            {
                Data.ServerIsLive = true;
                listserver.IsEnabled = false;

                //Там нужна смена картинки! (готово)
                imagesstartserver.Source = BitmapFrame.Create(new Uri("pack://application:,,,/Resources/StopBt.png"));

                BuildServer.Other.Class.FTP.FTPServer server = new Other.Class.FTP.FTPServer();
                server.Load((Settings.listServer)bufferserverinfo);
                server.Start();
                bufferserver = server;
            }
            else
            {
                Data.ServerIsLive = false;
                listserver.IsEnabled = true;

                imagesstartserver.Source = BitmapFrame.Create(new Uri("pack://application:,,,/Resources/StartBt.png"));

                var server = (Other.Class.FTP.FTPServer)bufferserver;
                server.Stop();
            }
        }

        private void btmoredelailsserver_Click(object sender, RoutedEventArgs e)//Больше инфы про сервер
        {
            if (bufferserverinfo == null)
                return;
            var serverinfo = (Settings.listServer)bufferserverinfo;

            System.Windows.MessageBox.Show($"Server name: {serverinfo.nameServer}\n" +
            $"Path server: {serverinfo.pathServer}\n" +
            $"Port server: {serverinfo.port}\n" +
            $"Description the server: {serverinfo.descriptionServer}\n" +
            $"Ver server: {serverinfo.ver}\n" +
            $"Path certificate: {serverinfo.pathCertificate}\n" +
            $"Passworld certificate: {serverinfo.passworldCertificate}\n" +
            $"Max connectins: {serverinfo.maxConnections}\n" +
            $"Type connect: {serverinfo.typeConnect}\n" +
            $"User: {serverinfo.user}\n" +
            $"Passworld: {serverinfo.passworld}",
            Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
