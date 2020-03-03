namespace Abstract_Factory
{
    interface IFoodAbstractFactory
    {
        ISandwich CreateSandwich();
        ISausage CreateSausage();
    }
}
