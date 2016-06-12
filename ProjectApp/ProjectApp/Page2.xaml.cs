using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ProjectApp
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    
    public partial class Page2 : Page
    {
        public Options.Color color { get; set; }
        public Options.Engine engine { get; set; }

        public List<FirstCar> carList = new List<FirstCar>();
        public string file = "";

        public Page2()
        {
            InitializeComponent();

            this.price.Content = "None";            
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void engineChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.engineComboBox.SelectedIndex == 1)
            {
                this.price.Content = "980 000 $";
                engine = Options.Engine.Entended1;

            }
            else if (this.engineComboBox.SelectedIndex == 2)
            {
                this.price.Content = "1 290 000 $";
                engine = Options.Engine.Extended2;
            }
            else if (this.engineComboBox.SelectedIndex == 0)
            {
                this.price.Content = "780 000 $";
                engine = Options.Engine.Default;
            }
        }

        private void colorChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.colorComboBox.SelectedIndex == 1)
            {
                color = Options.Color.white;
            }
            else if (this.colorComboBox.SelectedIndex == 2)
            {
                color = Options.Color.red;
            }
            else if (this.colorComboBox.SelectedIndex == 3)
            {
                color = Options.Color.yellow;
            }
            else if (this.colorComboBox.SelectedIndex == 0)
            {
                color = Options.Color.blue;
            }
        }

        private void addToShoppingList(object sender, RoutedEventArgs e)
        {
            try
            {
                if(this.colorComboBox.SelectedItem != null && this.engineComboBox.SelectedItem != null)
                {
                    using (StreamReader f = new StreamReader("shopping_cart.txt"))
                    {
                         file = f.ReadToEnd();
                    }
                    FirstCar car = new FirstCar("", color, engine, "");
                    carList.Add(car);
                    foreach(FirstCar fc in carList)
                    {
                        file += car.brand + ", " + car.name + ", " + car.engine + ", " + car.color + "\n";
                    }
                    using (StreamWriter ff = new StreamWriter("shopping_cart.txt"))
                    { ff.Write(file); }
                    MessageBox.Show("Car configuration had been added to the shopping cart. \nGo there to your list!");
                    carList.Remove(car);
                }
                else
                {
                    MessageBox.Show("You need to choose both the engine type and color before adding to shopping cart!");
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
