namespace ProjectApp
{
    public class SecondCar:MercedesCar
    {
        public string name { get; set; }

        public SecondCar(string carBrand, Options.Color carColor, Options.Engine carEngine)
            :base(carBrand, carColor, carEngine)
        {
            base.brand = carBrand;
            base.color = carColor;
            base.engine = carEngine;
        }

        public SecondCar(string brand, Options.Color color, Options.Engine engine, string name)
            :base(brand, color, engine)
        {
            this.name = "AMG GT";
        }
    }
}
