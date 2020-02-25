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

namespace BuildServer
{
    /// <summary>
    /// Логика взаимодействия для SettingsForm.xaml
    /// </summary>
    public partial class SettingsForm : Window
    {
        public SettingsForm()
        {
            InitializeComponent();
            Get();
        }

        /*---Это для настроик!---*/

        void Get()//отдача
        {
            //AutoStart

            Settings.Default.AutoStart = checkautostart.IsChecked.Value;

            if (checkautostart.IsChecked == true)
            {
                if (Settings.Default.NormalStart == true)
                {
                    radiostart.IsChecked = true;
                    radioserver.IsChecked = false;
                }
                else
                {
                    radiostart.IsChecked = false;
                    radioserver.IsChecked = true;
                }
            }

            Settings.Default.Save();
        }

        void Set()//Вставка
        {
            checkautostart.IsChecked = Settings.Default.AutoStart;

            if (checkautostart.IsChecked == true)
            {
                radioserver.IsEnabled = true;
                radiostart.IsEnabled = true;

                if (Settings.Default.NormalStart == true)
                {
                    radiostart.IsChecked = true;
                    radioserver.IsChecked = false;
                }
                else
                {
                    radiostart.IsChecked = false;
                    radioserver.IsChecked = true;
                }
            }

        }

        /*---Это для настроик!---*/

        //Я понимаю что так не правильно, но почему-то когда правильно сделано это не работает(((
        private void checkautostart_Click(object sender, RoutedEventArgs e)
        {
            if (checkautostart.IsChecked == true)
            {
                radiostart.IsEnabled = true;
                radioserver.IsEnabled = true;
                btradioserver.IsEnabled = true;

                if (radioserver.IsChecked == true)
                {
                    radiostart.IsChecked = false;
                }

                else if (radiostart.IsChecked == true)
                    radioserver.IsChecked = false;
            }
            else if (checkautostart.IsChecked == false)
            {
                radiostart.IsEnabled = false;
                radioserver.IsEnabled = false;
                btradioserver.IsEnabled = false;
            }
        }

        private void btsave_Click(object sender, RoutedEventArgs e)//Save
        {
            Set();
        }
    }
}
