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

namespace BuildServer
{
    /// <summary>
    /// Логика взаимодействия для AddServer.xaml
    /// </summary>
    public partial class AddServer : Window
    {
        string _RootPlaceFolder = null;
        object frame = null;

        public AddServer()
        {
            InitializeComponent();
            frame = new Other.Pages.FTP();
            framesettings.Navigate(frame);
        }

        private void btselectfolder_Click(object sender, RoutedEventArgs e)// select folder
        {

        }
    }
}
