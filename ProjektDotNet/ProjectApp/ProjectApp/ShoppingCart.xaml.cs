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
        string line { get; set; }
        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
        }

        public void refresh_invoke()
        {
            try
            {
                using (StreamReader f = new StreamReader("shopping_cart.txt"))
                {
                    while ((line = f.ReadLine()) != null)
                    {
                        this.textBlock.Text += line + "\n";
                    }
                }
            }
            catch(System.IO.FileNotFoundException)
            {
                using (StreamWriter f = new StreamWriter("shopping_cart.txt"))
                {
                    f.Write("");
                }
            }
            
        }

        private void buy(object sender, RoutedEventArgs e)
        {
            int checkIfNull = this.textBlock.Text.Length;
            if(checkIfNull == 0)
            {
                MessageBox.Show("Nothing to buy!");
            }
            else
            {  
                MessageBox.Show("Thank You for placing an order. We will contact You as soon as our consultant is ready!");
                this.textBlock.Text = "";
                using (StreamWriter f = new StreamWriter("shopping_cart.txt"))
                {
                    f.Write("");
                }
                line = "";
            }
        }
    }
}