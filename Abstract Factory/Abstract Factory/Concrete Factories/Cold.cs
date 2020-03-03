namespace Abstract_Factory
{
    public class Cold : IFoodAbstractFactory
    {
        public ISandwich CreateSandwich()
        {
            return new ColdSandwich();
        }

        public ISausage CreateSausage()
        {
            return new ColdSausage();
        }
    }
}
