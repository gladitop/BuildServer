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

namespace BuildServer.Other.Pages
{
    /// <summary>
    /// Логика взаимодействия для FTP.xaml
    /// </summary>
    public partial class FTP : Page
    {
        string _RootPlaceFolder = null;

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

            if (folderBrowser.ShowDialog()
                == System.Windows.Forms.DialogResult.OK)
            {
                _RootPlaceFolder = folderBrowser.SelectedPath;
                tbrootfoldet.Text = _RootPlaceFolder;
                Class.Data.RootPlaceFolder = _RootPlaceFolder;
            }
        }
    }
}
