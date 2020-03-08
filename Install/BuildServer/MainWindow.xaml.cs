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
using System.Threading;

namespace BuildServer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        object page = null;

        public MainWindow()
        {
            InitializeComponent();

            page = new Pages.Welcom();
            frame.Navigate(page);
            Thread thread = new Thread(new ThreadStart(Update));
            thread.Start();
        }

        public void Update()
        {
            while (true)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    Task.Delay(10).Wait();

                    if (Data.NewPages == true)
                    {
                        if (Data.Number == 2)
                        {
                            page = new Pages.Installing();
                            frame.Navigate(page);
                            Data.NewPages = false;
                        }
                    }
                }));
            }
        }

        private void mainWindows_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
