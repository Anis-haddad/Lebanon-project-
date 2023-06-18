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
using WpfApp1.folder_of_cities;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainCitiesUserControl.xaml
    /// </summary>
    public partial class MainCitiesUserControl : UserControl
    {
        public MainCitiesUserControl()
        {
            InitializeComponent();
            //Grid.SetZIndex(,int MaxValue);
            Grid.SetZIndex(BeirutisACity, int.MinValue);
            Grid.SetZIndex(MenuMainCities, int.MinValue);
            Grid.SetZIndex(HarrissaCityIsACity, int.MinValue);
            Grid.SetZIndex(FarayaCityIsACity, int.MinValue);
            Grid.SetZIndex(ByblosCityIsACity, int.MinValue);
            Grid.SetZIndex(BaalbakCityIsaCity, int.MinValue);
            Grid.SetZIndex(beirutImageClick, int.MinValue);
            Grid.SetZIndex(BaalbakImageClick, int.MinValue);

            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MainCitiesGoBackButton.Visibility = Visibility.Collapsed;
            //Grid.SetZIndex(MenuUserControlMenu, int.MaxValue);
        }
        private void GoBackToMainCities(object sender, RoutedEventArgs e)
        {
            Grid.SetZIndex(BeirutisACity, int.MinValue);
            Grid.SetZIndex(MenuMainCities, int.MinValue);
            Grid.SetZIndex(HarrissaCityIsACity, int.MinValue);
            Grid.SetZIndex(FarayaCityIsACity, int.MinValue);
            Grid.SetZIndex(ByblosCityIsACity, int.MinValue);
            Grid.SetZIndex(BaalbakCityIsaCity, int.MinValue);

            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MainCitiesGoBackButton.Visibility = Visibility.Collapsed;
        }
        private void BeirutButton(object sender, RoutedEventArgs e)
        {
            Grid.SetZIndex(BeirutisACity, int.MaxValue);
            Grid.SetZIndex(MenuMainCities, int.MinValue);
            Grid.SetZIndex(HarrissaCityIsACity, int.MinValue);
            Grid.SetZIndex(FarayaCityIsACity, int.MinValue);
            Grid.SetZIndex(ByblosCityIsACity, int.MinValue);
            Grid.SetZIndex(BaalbakCityIsaCity, int.MinValue);

            BeirutisACity.Visibility = Visibility.Visible;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MainCitiesGoBackButton.Visibility = Visibility.Visible;
        }

        

        private void HarrissaButton(object sender, RoutedEventArgs e)
        {
            Grid.SetZIndex(BeirutisACity, int.MinValue);
            Grid.SetZIndex(MenuMainCities, int.MinValue);
            Grid.SetZIndex(HarrissaCityIsACity, int.MaxValue);
            Grid.SetZIndex(FarayaCityIsACity, int.MinValue);
            Grid.SetZIndex(ByblosCityIsACity, int.MinValue);
            Grid.SetZIndex(BaalbakCityIsaCity, int.MinValue);
            Grid.SetZIndex(harrissaImageClick, int.MinValue);


            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Visible;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MainCitiesGoBackButton.Visibility = Visibility.Visible;
        }

        private void ByblosCityButton(object sender, RoutedEventArgs e)
        {
            Grid.SetZIndex(BeirutisACity, int.MinValue);
            Grid.SetZIndex(MenuMainCities, int.MinValue);
            Grid.SetZIndex(HarrissaCityIsACity, int.MinValue);
            Grid.SetZIndex(FarayaCityIsACity, int.MinValue);
            Grid.SetZIndex(ByblosCityIsACity, int.MaxValue);
            Grid.SetZIndex(BaalbakCityIsaCity, int.MinValue);

            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Visible;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MainCitiesGoBackButton.Visibility = Visibility.Visible;
        }

        private void FarayaCityButton(object sender, RoutedEventArgs e)
        {
            Grid.SetZIndex(BeirutisACity, int.MinValue);
            Grid.SetZIndex(MenuMainCities, int.MinValue);
            Grid.SetZIndex(HarrissaCityIsACity, int.MinValue);
            Grid.SetZIndex(FarayaCityIsACity, int.MaxValue);
            Grid.SetZIndex(ByblosCityIsACity, int.MinValue);
            Grid.SetZIndex(BaalbakCityIsaCity, int.MinValue);
            Grid.SetZIndex(FarayaImageClick, int.MinValue);

            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Visible;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MainCitiesGoBackButton.Visibility = Visibility.Visible;
        }

        private void BaalbakCityButton(object sender, RoutedEventArgs e)
        {
            Grid.SetZIndex(BeirutisACity, int.MinValue);
            Grid.SetZIndex(MenuMainCities, int.MinValue);
            Grid.SetZIndex(HarrissaCityIsACity, int.MinValue);
            Grid.SetZIndex(FarayaCityIsACity, int.MinValue);
            Grid.SetZIndex(ByblosCityIsACity, int.MinValue);
            Grid.SetZIndex(BaalbakCityIsaCity, int.MaxValue);

            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Visible;
            MainCitiesGoBackButton.Visibility = Visibility.Visible;
        }

        private void FarayaCityIsACity_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Grid.SetZIndex(BeirutisACity, int.MaxValue);
            Grid.SetZIndex(MenuMainCities, int.MinValue);
            Grid.SetZIndex(HarrissaCityIsACity, int.MinValue);
            Grid.SetZIndex(FarayaCityIsACity, int.MinValue);
            Grid.SetZIndex(ByblosCityIsACity, int.MinValue);
            Grid.SetZIndex(BaalbakCityIsaCity, int.MinValue);

            BeirutisACity.Visibility = Visibility.Visible;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MainCitiesGoBackButton.Visibility = Visibility.Visible;
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            HarrissaCityIsACity.Visibility=Visibility.Visible;
            Grid.SetZIndex(BeirutisACity, int.MinValue);
            Grid.SetZIndex(MenuMainCities, int.MinValue);
            Grid.SetZIndex(HarrissaCityIsACity, int.MaxValue);
            Grid.SetZIndex(FarayaCityIsACity, int.MinValue);
            Grid.SetZIndex(ByblosCityIsACity, int.MinValue);
            Grid.SetZIndex(BaalbakCityIsaCity, int.MinValue);
            Grid.SetZIndex(harrissaImageClick, int.MinValue);


            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Visible;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MainCitiesGoBackButton.Visibility = Visibility.Visible;
        }

        private void FarayaImageClick_MouseDown(object sender, MouseButtonEventArgs e)
        {
             FarayaCityIsACity.Visibility= Visibility.Visible;
            Grid.SetZIndex(BeirutisACity, int.MinValue);
            Grid.SetZIndex(MenuMainCities, int.MinValue);
            Grid.SetZIndex(HarrissaCityIsACity, int.MinValue);
            Grid.SetZIndex(FarayaCityIsACity, int.MaxValue);
            Grid.SetZIndex(ByblosCityIsACity, int.MinValue);
            Grid.SetZIndex(BaalbakCityIsaCity, int.MinValue);
            Grid.SetZIndex(FarayaImageClick, int.MinValue);

            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Visible;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MainCitiesGoBackButton.Visibility = Visibility.Visible;
        }

        private void ByblosImageClick_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BeirutisACity.Visibility=Visibility.Collapsed;
            Grid.SetZIndex(BeirutisACity, int.MinValue);
            Grid.SetZIndex(MenuMainCities, int.MinValue);
            Grid.SetZIndex(HarrissaCityIsACity, int.MinValue);
            Grid.SetZIndex(FarayaCityIsACity, int.MinValue);
            Grid.SetZIndex(ByblosCityIsACity, int.MaxValue);
            Grid.SetZIndex(BaalbakCityIsaCity, int.MinValue);

            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Visible;
            BaalbakCityIsaCity.Visibility = Visibility.Collapsed;
            MainCitiesGoBackButton.Visibility = Visibility.Visible;
        }

        private void BaalbakImageClick_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BeirutisACity.Visibility= Visibility.Collapsed;
            Grid.SetZIndex(BeirutisACity, int.MinValue);
            Grid.SetZIndex(MenuMainCities, int.MinValue);
            Grid.SetZIndex(HarrissaCityIsACity, int.MinValue);
            Grid.SetZIndex(FarayaCityIsACity, int.MinValue);
            Grid.SetZIndex(ByblosCityIsACity, int.MinValue);
            Grid.SetZIndex(BaalbakCityIsaCity, int.MaxValue);

            BeirutisACity.Visibility = Visibility.Collapsed;
            MenuMainCities.Visibility = Visibility.Collapsed;
            HarrissaCityIsACity.Visibility = Visibility.Collapsed;
            FarayaCityIsACity.Visibility = Visibility.Collapsed;
            ByblosCityIsACity.Visibility = Visibility.Collapsed;
            BaalbakCityIsaCity.Visibility = Visibility.Visible;
            MainCitiesGoBackButton.Visibility = Visibility.Visible;
        }
    }
}
