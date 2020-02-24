namespace Abstract_Factory
{
    interface IFoodAbstractFactory
    {
        IAbstractProductSandwich CreateProductSandwich();
        IAbstractProductSausage CreateProductSausage();
    }
}
