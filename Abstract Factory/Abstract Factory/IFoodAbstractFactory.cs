namespace Abstract_Factory
{
    interface IFoodAbstractFactory
    {
        ISandwich CreateProductSandwich();
        ISausage CreateProductSausage();
    }
}
