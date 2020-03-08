using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;

namespace BuildServer.Pages
{
    /// <summary>
    /// Логика взаимодействия для Installing.xaml
    /// </summary>
    public partial class Installing : Page
    {
        public Installing()
        {
            InitializeComponent();
        }

        public async Task Work()
        {
            this.Dispatcher.Invoke(new Action(() =>
            {
                WebClient web = new WebClient();
                web.DownloadProgressChanged += Web_DownloadProgressChanged;
                web.DownloadFileTaskAsync("https://raw.githubusercontent.com/damiralmaev/BuildServer/master/Update/GUI/BuildServer.rar",
                    $@"{Environment.GetFolderPath(Environment.SpecialFolder.InternetCache)}/BuildServerFile.rar");
            }));
        }

        private void Web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Dispatcher.Invoke(new Action(() =>
            {
                progress.Value = e.ProgressPercentage;
            }));
        }

        private async void installingForm_Loaded(object sender, RoutedEventArgs e)
        {
            Work();
            MessageBox.Show($@"{Environment.GetFolderPath(Environment.SpecialFolder.InternetCache)}/BuildServerFile.rar");
        }
    }
}
