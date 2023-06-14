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
    /// Interaction logic for MapOfLebanonUserControl.xaml
    /// </summary>
    public partial class MapOfLebanonUserControl : UserControl
    {
        public MapOfLebanonUserControl()
        {
            InitializeComponent();
            Grid.SetZIndex(MapOfLebanon, int.MinValue);
        }

        private void ByblosMapElipse_MouseEnter(object sender, MouseEventArgs e)
        {
            //ByblosMapElipse.Visibility = Visibility.Visible;
            ByblosMapElipse.Fill = new SolidColorBrush(Colors.DarkBlue);
            
        }

        private void ByblosMapElipse_MouseLeave(object sender, MouseEventArgs e)
        {
            //ByblosMapElipse.Visibility = Visibility.Hidden;
            ByblosMapElipse.Fill = new SolidColorBrush(Colors.Transparent);
        }

        private void BeirutMapElipse_MouseEnter(object sender, MouseEventArgs e)
        {
            BeirutMapElipse.Fill = new SolidColorBrush(Colors.DarkBlue);
        }

        private void BeirutMapElipse_MouseLeave(object sender, MouseEventArgs e)
        {
            BeirutMapElipse.Fill = new SolidColorBrush(Colors.Transparent);
        }

        private void BaalbakMapElipse_MouseEnter(object sender, MouseEventArgs e)
        {
            BaalbakMapElipse.Fill = new SolidColorBrush(Colors.DarkBlue);
        }

        private void BaalbakMapElipse_MouseLeave(object sender, MouseEventArgs e)
        {
            BaalbakMapElipse.Fill = new SolidColorBrush(Colors.Transparent);
        }

        private void HarissaMapElipse_MouseEnter(object sender, MouseEventArgs e)
        {
            HarissaMapElipse.Fill = new SolidColorBrush(Colors.DarkBlue);
        }

        private void HarissaMapElipse_MouseLeave(object sender, MouseEventArgs e)
        {
            HarissaMapElipse.Fill = new SolidColorBrush(Colors.Transparent);
        }

        private void FarayaMapElipse_MouseEnter(object sender, MouseEventArgs e)
        {
            FarayaMapElipse.Fill = new SolidColorBrush(Colors.DarkBlue);
        }

        private void FarayaMapElipse_MouseLeave(object sender, MouseEventArgs e)
        {
            FarayaMapElipse.Fill = new SolidColorBrush(Colors.Transparent);
        }

        private void ByblosMapElipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ByblosMapElipse.Fill = new SolidColorBrush(Colors.Red);

            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Visible;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MapOfLebanon.Visibility = Visibility.Hidden;
            GoBackFromMainCities.Visibility = Visibility.Visible;
        }

        private void BaalbakMapElipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BaalbakMapElipse.Fill = new SolidColorBrush(Colors.Red);

            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Visible;
            MapOfLebanon.Visibility = Visibility.Hidden;
            GoBackFromMainCities.Visibility = Visibility.Visible;
        }

        private void BeirutMapElipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BeirutMapElipse.Fill = new SolidColorBrush(Colors.Red);
            BeirutisACity.Visibility = Visibility.Visible;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MapOfLebanon.Visibility = Visibility.Hidden;
            GoBackFromMainCities.Visibility = Visibility.Visible;
        }

        private void HarissaMapElipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HarissaMapElipse.Fill = new SolidColorBrush(Colors.Red);
            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Visible;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MapOfLebanon.Visibility = Visibility.Hidden;
            GoBackFromMainCities.Visibility = Visibility.Visible;
        }

        private void FarayaMapElipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FarayaMapElipse.Fill = new SolidColorBrush(Colors.Red);
            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Visible;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MapOfLebanon.Visibility = Visibility.Hidden;
            GoBackFromMainCities.Visibility = Visibility.Visible;
        }

        private void GoBackFromMainCities_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void GoBackFromMainCities_Click(object sender, RoutedEventArgs e)
        {
            BeirutisACity.Visibility = Visibility.Hidden;
            MenuMainCities.Visibility = Visibility.Hidden;
            HarrissaCityIsACity.Visibility = Visibility.Hidden;
            FarayaCityIsACity.Visibility = Visibility.Hidden;
            ByblosCityIsACity.Visibility = Visibility.Hidden;
            BaalbakCityIsaCity.Visibility = Visibility.Hidden;
            MapOfLebanon.Visibility = Visibility.Visible;
            GoBackFromMainCities.Visibility = Visibility.Hidden;
        }
    }
}
