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


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            map secondWindow = new map();
          
            secondWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            main_cities secondWindow = new main_cities();
            secondWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            about_us secondWindow = new about_us();
            secondWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            activities_to_do secondWindow = new activities_to_do();
            secondWindow.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            facts secondWindow = new facts();
            secondWindow.Show();
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
