namespace Abstract_Factory
{
    public class Cold : IFoodAbstractFactory
    {
        public ISandwich CreateProductSandwich()
        {
            return new ColdSandwich();
        }

        public ISausage CreateProductSausage()
        {
            return new ColdSausage();
        }
    }
}
