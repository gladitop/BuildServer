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
        public object bufferserverinfo;

        public MainWindow()
        {
            InitializeComponent();

            //SettingsManager.Load();
            //SettingsManager.Save();
            //Other.Class.SettingsManager.Load();
            //var settings = new Settings();
            //settings.ListServer.Add(new Settings.listServer() { descriptionServer = "2 des", nameServer = "Test 2",
            //pathServer = "Tester2/lol", ver = "2.0"});
            ///Data.Settings = settings;
            //SettingsManager.Save();

            LoadingListServer();
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
        }

        private void btdeleteserver_Click(object sender, RoutedEventArgs e)//Delete server
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)//Close
        {
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
    }
}
