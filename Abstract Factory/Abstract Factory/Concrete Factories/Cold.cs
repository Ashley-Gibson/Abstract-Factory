namespace Abstract_Factory
{
    public class Cold : IFoodAbstractFactory
    {
        public IAbstractProductSandwich CreateProductSandwich()
        {
            return new ColdSandwich();
        }

        public IAbstractProductSausage CreateProductSausage()
        {
            return new ColdSausage();
        }
    }
}
