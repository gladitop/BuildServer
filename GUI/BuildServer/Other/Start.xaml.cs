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
using BuildServer.Properties;

namespace BuildServer.Other
{
    /// <summary>
    /// Логика взаимодействия для Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        public Start()
        {
            InitializeComponent();
            //MessageBox.Show(Convert.ToString(Settings.Default.StartProgram));
            if (Settings.Default.StartProgram == true)
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Hide();//!!!
            }
            else
            {
                StartProgram main = new StartProgram();
                main.Show();
                this.Hide();
            }
        }
    }
}
