using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ProjectApp
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            
        }

        public void toFirstCarConfig(object sender, RoutedEventArgs e)
        {
            using (StreamWriter ff = new StreamWriter("choice.txt"))
            {
                ff.Write("1");
            }
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("CarsConfigs.xaml", UriKind.RelativeOrAbsolute));

        }

        private void toSecondCarConfig(object sender, RoutedEventArgs e)
        {
            using (StreamWriter ff = new StreamWriter("choice.txt"))
            {
                ff.Write("2");
            }
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("CarsConfigs.xaml", UriKind.RelativeOrAbsolute));
        }

        private void toThirdCarConfig(object sender, RoutedEventArgs e)
        {
            using (StreamWriter ff = new StreamWriter("choice.txt"))
            {
                ff.Write("3");
            }
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("CarsConfigs.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
