namespace ProjectApp
{
    public class ThirdCar:MercedesCar
    {
        public string name { get; set; }
        public int[] prices = new int[3] { 900000, 1290000, 1550000 };

        public ThirdCar(string carBrand, Options.Color carColor, Options.Engine carEngine, int price)
            :base(carBrand, carColor, carEngine, price)
        {
            base.brand = carBrand;
            base.color = carColor;
            base.engine = carEngine;
            base.price = price;
        }

        public ThirdCar(string brand, Options.Color color, Options.Engine engine, string name, int price)
            :base(brand, color, engine, price)
        {
            this.name = "CLA Coupe";
        }
    }
}
