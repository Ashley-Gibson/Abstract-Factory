namespace Abstract_Factory
{
    public class Hot : IFoodAbstractFactory
    {
        public ISandwich CreateSandwich()
        {
            return new HotSandwich();
        }

        public ISausage CreateSausage()
        {
            return new HotSausage();
        }
    }
}
