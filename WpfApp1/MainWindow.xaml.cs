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
            Grid.SetZIndex(AboutUsUserControlMenu, int.MinValue);
            Grid.SetZIndex(MenuUserControlMenu, int.MinValue);
            Grid.SetZIndex(MainCitiesUserControlMenu, int.MinValue);
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

        private void MainCitiesMenuButton(object sender, RoutedEventArgs e)
        {
            menu.Margin = MainCities2.Margin;
            Grid.SetZIndex(AboutUsUserControlMenu, int.MinValue);
            Grid.SetZIndex(MenuUserControlMenu, int.MinValue);
            Grid.SetZIndex(MainCitiesUserControlMenu, int.MaxValue);
        }

        private void MapOfLebanon_Click(object sender, RoutedEventArgs e)
        {
            menu.Margin = MapOfLebanon.Margin;
        }

        private void ActivitiesToDoClick(object sender, RoutedEventArgs e)
        {
            menu.Margin = ActivitiesToDo.Margin;
        }

        private void InterestingFactsClick(object sender, RoutedEventArgs e)
        {
            menu.Margin = InterestingFacts.Margin;
        }

        private void AboutUSClick(object sender, RoutedEventArgs e)
        {
            menu.Margin = AboutUS.Margin;
            Grid.SetZIndex(AboutUsUserControlMenu, int.MaxValue);
            Grid.SetZIndex(MenuUserControlMenu, int.MinValue);
            Grid.SetZIndex(MainCitiesUserControlMenu, int.MinValue);

            // LayerContainer.Children.Clear();

            // UserControl layer1 = new UserControl();
            // LayerContainer.Children.Add(layer1);
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {

        }

    }
}
