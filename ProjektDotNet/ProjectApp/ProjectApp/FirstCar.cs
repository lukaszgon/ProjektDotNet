namespace ProjectApp
{
    public class FirstCar:MercedesCar
    {
        public string name { get; set; }
        public int[] prices = new int[3] { 780000, 980000, 1290000 };

        public FirstCar(string carBrand, Options.Color carColor, Options.Engine carEngine, int price)
            :base(carBrand, carColor, carEngine, price)
        {
            base.brand = carBrand;
            base.color = carColor;
            base.engine = carEngine;
            base.price = price;
            
        }

        public FirstCar(string brand, Options.Color color, Options.Engine engine, string name, int price)
            :base(brand, color, engine, price)
        {
            this.name = "AMG A45";
        }
       
    }
}
