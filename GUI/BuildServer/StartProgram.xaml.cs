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
using System.Net;
using BuildServer.Other.Class;

namespace BuildServer
{
    /// <summary>
    /// Логика взаимодействия для StartProgram.xaml
    /// </summary>
    public partial class StartProgram : Window
    {
        bool close = false;
        bool error = false;
        string errorinfo = null;

        public StartProgram()
        {
            InitializeComponent();

            // Loading LICENSE

            try
            {
                using (WebClient web = new WebClient())
                {
                    tblis.Text = web.DownloadString("https://raw.githubusercontent.com/damiralmaev/BuildServer/master/LICENSE");
                }
            }
            catch (Exception ex) {
                errorinfo = ex.Message;
                error = true;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)//Close
        {
            if (close == false)
                Environment.Exit(0);
        }

        private void tbaccept_Click(object sender, RoutedEventArgs e)//Done
        {
            Data.Settings.StartProgram = true;
            SettingsManager.Save();
            MainWindow main = new MainWindow();
            main.Show();
            close = true;
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (error == true)
            {
                MessageBox.Show($"Error! {errorinfo}", Title, MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(0);
            }
        }
    }
}
