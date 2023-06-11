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
            Grid.SetZIndex(MenuUserControlMenu, int.MaxValue);
            Grid.SetZIndex(MainCitiesUserControlMenu, int.MinValue);
            Grid.SetZIndex(MapOfLebanonUserControl, int.MinValue);
            Grid.SetZIndex(ActivitiesToDoUserControl, int.MinValue);
            Grid.SetZIndex(IntrestingFactAboutLebanonUserControl, int.MinValue);
            Grid.SetZIndex(QuizUserControl, int.MinValue);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            map secondWindow = new map();
          
            secondWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
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
            Grid.SetZIndex(MapOfLebanonUserControl, int.MinValue);
            Grid.SetZIndex(ActivitiesToDoUserControl, int.MinValue);
            Grid.SetZIndex(IntrestingFactAboutLebanonUserControl, int.MinValue);
            Grid.SetZIndex(QuizUserControl, int.MinValue);
        }

        private void MapOfLebanon_Click(object sender, RoutedEventArgs e)
        {
            menu.Margin = MapOfLebanon.Margin;
            Grid.SetZIndex(AboutUsUserControlMenu, int.MinValue);
            Grid.SetZIndex(MenuUserControlMenu, int.MinValue);
            Grid.SetZIndex(MainCitiesUserControlMenu, int.MinValue);
            Grid.SetZIndex(MapOfLebanonUserControl, int.MaxValue);
            Grid.SetZIndex(ActivitiesToDoUserControl, int.MinValue);
            Grid.SetZIndex(IntrestingFactAboutLebanonUserControl, int.MinValue);
            Grid.SetZIndex(QuizUserControl, int.MinValue);
        }

        private void ActivitiesToDoClick(object sender, RoutedEventArgs e)
        {
            menu.Margin = ActivitiesToDo.Margin;
            Grid.SetZIndex(AboutUsUserControlMenu, int.MinValue);
            Grid.SetZIndex(MenuUserControlMenu, int.MinValue);
            Grid.SetZIndex(MainCitiesUserControlMenu, int.MinValue);
            Grid.SetZIndex(MapOfLebanonUserControl, int.MinValue);
            Grid.SetZIndex(ActivitiesToDoUserControl, int.MaxValue);
            Grid.SetZIndex(IntrestingFactAboutLebanonUserControl, int.MinValue);
            Grid.SetZIndex(QuizUserControl, int.MinValue);
        }

        private void InterestingFactsClick(object sender, RoutedEventArgs e)
        {
            menu.Margin = InterestingFacts.Margin;
            Grid.SetZIndex(AboutUsUserControlMenu, int.MinValue);
            Grid.SetZIndex(MenuUserControlMenu, int.MinValue);
            Grid.SetZIndex(MainCitiesUserControlMenu, int.MinValue);
            Grid.SetZIndex(MapOfLebanonUserControl, int.MinValue);
            Grid.SetZIndex(ActivitiesToDoUserControl, int.MinValue);
            Grid.SetZIndex(IntrestingFactAboutLebanonUserControl, int.MaxValue);
            Grid.SetZIndex(QuizUserControl, int.MinValue);
        }

        private void AboutUSClick(object sender, RoutedEventArgs e)
        {
            menu.Margin = AboutUS.Margin;
            Grid.SetZIndex(AboutUsUserControlMenu, int.MaxValue);
            Grid.SetZIndex(MenuUserControlMenu, int.MinValue);
            Grid.SetZIndex(MainCitiesUserControlMenu, int.MinValue);
            Grid.SetZIndex(MapOfLebanonUserControl, int.MinValue);
            Grid.SetZIndex(ActivitiesToDoUserControl, int.MinValue);
            Grid.SetZIndex(IntrestingFactAboutLebanonUserControl, int.MinValue);
            Grid.SetZIndex(QuizUserControl, int.MinValue);

            // LayerContainer.Children.Clear();

            // UserControl layer1 = new UserControl();
            // LayerContainer.Children.Add(layer1);
        }
        private void QuizButtonClick(object sender, RoutedEventArgs e)
        {
            menu.Margin = QUIZbutton.Margin;
            Grid.SetZIndex(AboutUsUserControlMenu, int.MaxValue);
            Grid.SetZIndex(MenuUserControlMenu, int.MinValue);
            Grid.SetZIndex(MainCitiesUserControlMenu, int.MinValue);
            Grid.SetZIndex(MapOfLebanonUserControl, int.MinValue);
            Grid.SetZIndex(ActivitiesToDoUserControl, int.MinValue);
            Grid.SetZIndex(IntrestingFactAboutLebanonUserControl, int.MinValue);
            Grid.SetZIndex(QuizUserControl, int.MaxValue);
        }
        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
