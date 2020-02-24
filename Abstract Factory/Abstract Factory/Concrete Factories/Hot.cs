namespace Abstract_Factory
{
    public class Hot : IFoodAbstractFactory
    {
        public IAbstractProductSandwich CreateProductSandwich()
        {
            return new HotSandwich();
        }

        public IAbstractProductSausage CreateProductSausage()
        {
            return new HotSausage();
        }
    }
}
