using System;
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

        private void toThePage2(object sender, RoutedEventArgs e)
        { 
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("Page2.xaml", UriKind.RelativeOrAbsolute)); 
        }

        private void toThePage3(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("Page3.xaml", UriKind.RelativeOrAbsolute));
        }

        private void toThePage4(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("Page4.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
