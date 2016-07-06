using System.IO;
using System.Windows;

namespace ProjectApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new Page1();
            using (StreamWriter f = new StreamWriter("shopping_cart.txt"))
            {
                f.Write("");
            }  
        }

        private void goToShoppingCart(object sender, RoutedEventArgs e)
        {
            ShoppingCart  newCart = new ShoppingCart();
            newCart.refresh_invoke();
            Main.Content = newCart;
        }
    }
}
