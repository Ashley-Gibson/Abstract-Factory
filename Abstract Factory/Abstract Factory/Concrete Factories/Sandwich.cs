namespace Abstract_Factory
{
    public class Sandwich : IFoodAbstractFactory
    {
        public IAbstractProductCold CreateProductCold()
        {
            return new ColdSandwich();
        }

        public IAbstractProductHot CreateProductHot()
        {
            return new HotSandwich();
        }
    }
}
