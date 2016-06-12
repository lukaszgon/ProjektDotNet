namespace ProjectApp
{
    public class FirstCar:MercedesCar
    {
        public string name { get; set; }

        public FirstCar(string carBrand, Options.Color carColor, Options.Engine carEngine)
            :base(carBrand, carColor, carEngine)
        {
            base.brand = carBrand;
            base.color = carColor;
            base.engine = carEngine;
            
        }

        public FirstCar(string brand, Options.Color color, Options.Engine engine, string name)
            :base(brand, color, engine)
        {
            this.name = "AMG A45";
        }
       
    }
}
