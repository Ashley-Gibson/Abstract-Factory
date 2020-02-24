namespace Abstract_Factory
{
    public class Sausage : IFoodAbstractFactory
    {
        public IAbstractProductCold CreateProductCold()
        {
            return new ColdSausage();
        }

        public IAbstractProductHot CreateProductHot()
        {
            return new HotSausage();
        }
    }
}
