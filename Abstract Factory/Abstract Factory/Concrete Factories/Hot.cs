namespace Abstract_Factory
{
    public class Hot : IFoodAbstractFactory
    {
        public ISandwich CreateProductSandwich()
        {
            return new HotSandwich();
        }

        public ISausage CreateProductSausage()
        {
            return new HotSausage();
        }
    }
}
