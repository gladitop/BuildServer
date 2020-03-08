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

namespace BuildServer.Other.Windows
{
    /// <summary>
    /// Логика взаимодействия для SelecteDescriptionServer.xaml
    /// </summary>
    public partial class SelecteDescriptionServer : Window
    {
        public SelecteDescriptionServer()
        {
            InitializeComponent();

            tb.Text = Data.DescriptionServer;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //save info

            Data.DescriptionServer = tb.Text;
        }
    }
}
