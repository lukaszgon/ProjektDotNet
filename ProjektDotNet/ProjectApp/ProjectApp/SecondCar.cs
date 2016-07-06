namespace ProjectApp
{
    public class SecondCar:MercedesCar
    {
        public string name { get; set; }
        public int[] prices = new int[3] { 1100000, 1480000, 1790000 };

        public SecondCar(string carBrand, Options.Color carColor, Options.Engine carEngine, int price)
            :base(carBrand, carColor, carEngine, price)
        {
            base.brand = carBrand;
            base.color = carColor;
            base.engine = carEngine;
            base.price = price;
        }

        public SecondCar(string brand, Options.Color color, Options.Engine engine, string name, int price)
            :base(brand, color, engine, price)
        {
            this.name = "AMG GT";
        }
    }
}
