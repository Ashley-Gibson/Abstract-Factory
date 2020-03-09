namespace Abstract_Factory
{
    public interface IFoodAbstractFactory
    {
        ISandwich CreateSandwich();
        ISausage CreateSausage();
    }
}
