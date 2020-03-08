using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BuildServer.Other.Class;
using BuildServer.Other.Windows;

namespace BuildServer.Other.Pages
{
    /// <summary>
    /// Логика взаимодействия для FTP.xaml
    /// </summary>
    public partial class FTP : Page
    {
        string _RootPlaceFolder = null;
        string _pathCertificate = null;
        string _passworldCertificate = null;

        public FTP()
        {
            InitializeComponent();
            Copy();
        }

        void Copy()
        {
            if(Class.Data.RootPlaceFolder != null)
                tbrootfoldet.Text = Class.Data.RootPlaceFolder;
        }

        private void btselectfolder_Click(object sender, RoutedEventArgs e)// select folder
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                _RootPlaceFolder = folderBrowser.SelectedPath;
                tbrootfoldet.Text = _RootPlaceFolder;
                Class.Data.RootPlaceFolder = _RootPlaceFolder;
            }
        }

        private void tbnameroot_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Class.Data.RootNameFolder = tbnameroot.Text;
        }

        private void tbport_SelectionChanged(object sender, RoutedEventArgs e)// port
        {
            /* Error!
            try
            {
                Class.Data.Port = Convert.ToString(tbport.Text);
            }
            catch
            {
                tbport.Text = "";
                System.Windows.MessageBox.Show("Error! You can only use numbers!",
                    Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            */
        }

        private void tbport_TextChanged(object sender, TextChangedEventArgs e)// port
        {
            try
            {
                Class.Data.Port = Convert.ToString(tbport.Text);
            }
            catch
            {
                tbport.Text = "";
                System.Windows.MessageBox.Show("Error! You can only use numbers!",
                    Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btselectcertificate_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                _pathCertificate = folderBrowser.SelectedPath;
                tbpathcertificate.Text = _pathCertificate;
                Class.Data.PathCertificate = _pathCertificate;
                tbpassworldcertificate.IsEnabled = true;
            }
        }

        private void tbdescriptionserver_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Data.DescriptionServer = tbdescriptionserver.Text;
        }

        private void btdescriptionserver_Click(object sender, RoutedEventArgs e)
        {
            SelecteDescriptionServer selecte = new SelecteDescriptionServer();
            selecte.ShowDialog();
            tbdescriptionserver.Text = Data.DescriptionServer;
        }
    }
}
