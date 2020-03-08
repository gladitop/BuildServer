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
            SettingsManager.Save();
            MessageBox.Show("1");
            SettingsManager.Load();
            MessageBox.Show("2");
            //Баг при загрузки json файла
            var settings = (Settings)Data.Settings;
            MessageBox.Show("8");
            if (settings.StartProgram == true)
            {
                MessageBox.Show("9");
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
