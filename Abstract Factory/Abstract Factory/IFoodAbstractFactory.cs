namespace Abstract_Factory
{
    interface IFoodAbstractFactory
    {
        IAbstractProductCold CreateProductCold();
        IAbstractProductHot CreateProductHot();
    }
}
