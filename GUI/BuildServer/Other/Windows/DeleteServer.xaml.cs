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
using BuildServer.Other.Class;
using System.IO;
using System.Threading;

namespace BuildServer.Other.Windows
{
    /// <summary>
    /// Логика взаимодействия для DeleteServer.xaml
    /// </summary>
    public partial class DeleteServer : Window
    {
        bool exit = true;//Тут наоборот!
        int DeleteFileLength = 0;
        int DeleteDirectoryLength = 0;

        public DeleteServer()
        {
            InitializeComponent();
        }

        private void deleteServer_Loaded(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(Data.PathServerDelete);

            //Thread th = new Thread(new ThreadStart(Work));
            //th.IsBackground = true;//Я не знал про эту штуку! (Gladi)
            //th.Start();

            Thread delete = new Thread(new ThreadStart(Deletings));
            delete.IsBackground = true;
            delete.Start();
        }

        void Deletings()//Есть не понятный баг
        {
            this.Dispatcher.Invoke(new Action(() =>
            {
                while(true)
                {
                    Task.Delay(500).Wait();
                    lbdeleting.Content = "Deleting";

                    Task.Delay(500).Wait();
                    lbdeleting.Content = "Deleting.";

                    Task.Delay(500).Wait();
                    lbdeleting.Content = "Deleting..";

                    Task.Delay(500).Wait();
                    lbdeleting.Content = "Deleting...";
                }
            }));
        }

        void Work()
        {
            this.Dispatcher.Invoke(new Action(() =>
            {
                string[] pathfiles = Directory.GetFiles(Data.PathServerDelete,
                    "*", SearchOption.AllDirectories);
                DeleteFileLength = pathfiles.Length;

                string[] pathdirectories = Directory.GetDirectories(Data.PathServerDelete,
                    "*", SearchOption.AllDirectories);
                DeleteDirectoryLength = pathdirectories.Length;

                progress.Maximum = DeleteDirectoryLength + DeleteFileLength;

                foreach (string pathfile in pathfiles)
                {
                    try
                    {
                        File.Delete(pathfile);
                        progress.Value++;
                    }
                    catch { }
                }

                foreach (string pathdirectory in pathdirectories)
                {
                    try
                    {
                        Directory.Delete(pathdirectory, true);
                        progress.Value++;
                    }
                    catch { }
                }

                exit = false;
                this.Close();
            }));
        }

        private void deleteServer_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = exit;
        }
    }
}
