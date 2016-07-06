using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace ProjectApp
{
    /// <summary>
    /// Interaction logic for CarsConfigs.xaml
    /// </summary>
    public partial class CarsConfigs : Page
    {
        public int carChoice { get; set; }
        public Options.Color color { get; set; }
        public Options.Engine engine { get; set; }
        public int[] car_price = new int[3];
        public int actual_price { get; set; }
        public string file = "";
        public List<FirstCar> carList1 = new List<FirstCar>();
        public List<SecondCar> carList2 = new List<SecondCar>();
        public List<ThirdCar> carList3 = new List<ThirdCar>();

        public CarsConfigs()
        {
            InitializeComponent();
            this.price.Content = "None";
            using (StreamReader choiceFile = new StreamReader("choice.txt"))
            {
                string choiceFileNum = choiceFile.ReadToEnd();
                carChoice = Int32.Parse(choiceFileNum);
            }
            switch (carChoice)
            {
                case 1:
                    addFirstCarConfigs();
                    break;
                case 2:
                    addSecondCarConfigs();
                    break;
                case 3:
                    addThirdCarConfigs();
                    break;
                default:
                    addFirstCarConfigs();
                    break;
            }
        }

        private void addFirstCarConfigs()
        {
            FirstCar newCar = new FirstCar("", Options.Color.blue, Options.Engine.Default, 0);
            car_price[0] = newCar.prices[0];
            car_price[1] = newCar.prices[1];
            car_price[2] = newCar.prices[2];
            this.carImage.Source = new BitmapImage(new Uri(@"pack://application:,,,/ProjectApp;component/amga454matic-big.jpg"));
        }

        private void addSecondCarConfigs()
        {
            SecondCar newCar = new SecondCar("", Options.Color.blue, Options.Engine.Default, 0);
            car_price[0] = newCar.prices[0];
            car_price[1] = newCar.prices[1];
            car_price[2] = newCar.prices[2];
            this.carImage.Source = new BitmapImage(new Uri(@"pack://application:,,,/ProjectApp;component/amggt-big.jpg"));
        }

        private void addThirdCarConfigs()
        {
            ThirdCar newCar = new ThirdCar("", Options.Color.blue, Options.Engine.Default, 0);
            car_price[0] = newCar.prices[0];
            car_price[1] = newCar.prices[1];
            car_price[2] = newCar.prices[2];
            this.carImage.Source = new BitmapImage(new Uri(@"pack://application:,,,/ProjectApp;component/clacoupe-big.jpg"));
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
        
        private void engineChanged(object sender, SelectionChangedEventArgs e)
        { 
            if (this.engineComboBox.SelectedIndex == 1)
            {
                this.price.Content = car_price[1].ToString() + "$";
                engine = Options.Engine.Extended1;
                actual_price = car_price[1];

            }
            else if (this.engineComboBox.SelectedIndex == 2)
            {
                this.price.Content = car_price[2].ToString() + "$";
                engine = Options.Engine.Extended2;
                actual_price = car_price[2];
            }
            else if (this.engineComboBox.SelectedIndex == 0)
            {
                this.price.Content = car_price[0].ToString() + "$";
                engine = Options.Engine.Default;
                actual_price = car_price[0];
            }
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void addToShoppingCart(object sender, RoutedEventArgs e)
        {
            if (this.colorComboBox.SelectedItem != null && this.engineComboBox.SelectedItem != null)
            {
                using (StreamReader f = new StreamReader("shopping_cart.txt"))
                {
                    file = f.ReadToEnd();
                }
                switch (carChoice)
                {
                    case 1:
                        addFirstCarToShoppingCart();
                        break;
                    case 2:
                        addSecondCarToShoppingCart();
                        break;
                    case 3:
                        addThirdCarToShoppingCart();
                        break;
                }

                using (StreamWriter ff = new StreamWriter("shopping_cart.txt"))
                {
                    ff.Write(file);
                }
                MessageBox.Show("Car configuration had been added to the shopping cart. \nGo there to see your list!");
            }
            else
            {
                MessageBox.Show("You need to choose both the engine type and the color before adding to the shopping cart!");
            }

        }

        private void addFirstCarToShoppingCart()
        {
            FirstCar car = new FirstCar("", color, engine, "", actual_price);
            carList1.Add(car);
            foreach (FirstCar fc in carList1)
            {
                file += car.brand + ", " + car.name + ", " + car.engine + ", " + car.color + ", " + car.price + "$\n";
            }
            carList1.Remove(car);
        }

        private void addSecondCarToShoppingCart()
        {
            SecondCar car = new SecondCar("", color, engine, "", actual_price);
            carList2.Add(car);
            foreach (SecondCar fc in carList2)
            {
                file += car.brand + ", " + car.name + ", " + car.engine + ", " + car.color + ", " + car.price + "$\n";
            }
            carList2.Remove(car);
        }

        private void addThirdCarToShoppingCart()
        {
            ThirdCar car = new ThirdCar("", color, engine, "", actual_price);
            carList3.Add(car);
            foreach (ThirdCar fc in carList3)
            {
                file += car.brand + ", " + car.name + ", " + car.engine + ", " + car.color + ", " + car.price + "$\n";
            }
            carList3.Remove(car);
        }
    }
}
