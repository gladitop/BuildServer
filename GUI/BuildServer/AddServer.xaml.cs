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
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;
using BuildServer.Other.Class;

namespace BuildServer
{
    /// <summary>
    /// Логика взаимодействия для AddServer.xaml
    /// </summary>
    public partial class AddServer : Window
    {
        object frame = null;

        public AddServer()
        {
            InitializeComponent();
            frame = new Other.Pages.FTP();
            framesettings.Navigate(frame);
            DataManager.Reset();
        }

        private void btselectfolder_Click(object sender, RoutedEventArgs e)// select folder
        {

        }

        private void btinfoserver_Click(object sender, RoutedEventArgs e)// info on server
        {
            System.Windows.MessageBox.Show($"Server name: {Data.RootNameFolder}\n" +
                $"Path server: {Data.RootPlaceFolder}\n" +
                $"Port server: {Data.Port}\n" +
                $"Description the server: {Data.DescriptionServer}\n" +
                $"Ver server: {Data.ver}\n" +
                $"Path certificate: {Data.PathCertificate}\n" +
                $"Passworld certificate: {Data.PassworldCertificate}\n" +
                $"Max connectins: {Data.MaxConnections}\n" +
                $"Type connect: {Data.TypeConnect}\n" +
                $"User: {Data.User}\n" +
                $"Passworld: {Data.Passworld}",
                Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        //Прочее

        public bool CheckAddServer(string nameserver)//Проверка переменных для создания сервеар
        {
            var set = (Settings)Data.Settings;

            foreach (var settings in set.ListServer)
            {
                if (settings.nameServer == nameserver)
                    return false;
            }

            return true;
        }

        private void btbuildserver_Click(object sender, RoutedEventArgs e)
        {
            if (CheckAddServer(Data.RootNameFolder))
            {
                Other.Class.FTP.FTPCreate.Create();
                Other.Class.DataManager.Reset();
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Такой сервер уже есть!", Title, 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
