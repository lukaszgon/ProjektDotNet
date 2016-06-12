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
            { f.Write(""); }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new ShoppingCart();
        }
    }
}
