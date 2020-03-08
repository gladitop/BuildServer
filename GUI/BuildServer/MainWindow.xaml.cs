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
            var settings = (Settings)Data.Settings;
            settings.ListServer.Add(new Settings.listServer()
            {
                descriptionServer = Data.DescriptionServer,
                nameServer = Data.RootNameFolder,
                pathServer = Data.RootPlaceFolder,
                passworld = null,
                ver = Data.ver,
                pathCertificate = Data.PathCertificate,
                passworldCertificate = Data.PassworldCertificate,
                typeConnect = "ftp",
                user = null
            });
            Data.Settings = settings;
            SettingsManager.Save();
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
    }
}
