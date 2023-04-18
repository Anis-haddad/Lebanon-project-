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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for map.xaml
    /// </summary>
    public partial class map : Window
    {
        public map()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Beirut secondWindow = new Beirut();
            secondWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            jounieh secondWindow = new jounieh();
            secondWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            byblos secondWindow = new byblos();
            secondWindow.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           jounieh secondWindow = new jounieh();
            secondWindow.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            harrissa secondWindow = new harrissa();
            secondWindow.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            faraya secondWindow = new faraya();
            secondWindow.Show();
        }
    }
}
