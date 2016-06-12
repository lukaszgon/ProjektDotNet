using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ProjectApp
{
    /// <summary>
    /// Interaction logic for ShoppingCart.xaml
    /// </summary>
    public partial class ShoppingCart : Page
    {
        public bool refreshed = false;

        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if(refreshed == false)
            {
                string line;
                using (StreamReader f = new StreamReader("shopping_cart.txt"))
                {
                    while ((line = f.ReadLine()) != null)
                    {
                        this.textBlock.Text += "\n" + line;
                    }
                }
                refreshed = true;
            }
            else
            {
                MessageBox.Show("Current list is already refreshed!");
            }
            
        }
    }
}
