namespace ProjectApp
{
    public class ThirdCar:MercedesCar
    {
        public string name { get; set; }

        public ThirdCar(string carBrand, Options.Color carColor, Options.Engine carEngine)
            :base(carBrand, carColor, carEngine)
        {
            base.brand = carBrand;
            base.color = carColor;
            base.engine = carEngine;
        }

        public ThirdCar(string brand, Options.Color color, Options.Engine engine, string name)
            :base(brand, color, engine)
        {
            this.name = "CLA Coupe";
        }
    }
}
