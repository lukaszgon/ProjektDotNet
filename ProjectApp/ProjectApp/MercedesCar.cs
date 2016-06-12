namespace ProjectApp
{
    interface ICarType
    {
        string brand { get; set; }
        Options.Color color { get; set; }

        string getCall();
    }

    public class MercedesCar:ICarType
    {
        public string brand { get; set; }
        public Options.Color color { get; set; }
        public Options.Engine engine { get; set; }

        public MercedesCar(string brand, Options.Color color, Options.Engine engine)
        {
            this.brand = "Mercedes";
            this.color = color;
            this.engine = engine;
        }
        public string getCall()
        {
            return "If you want us to call, please fill the Shopping Cart with at least one element";
        }
    }
}
