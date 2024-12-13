namespace DesignPattern.CreationalPatterns.AbstractFactory;

public interface ICarFactory
{
    ICar CreateCar();
    ICarSpecification CreateSpecification();
}

class NorthAmericaCarFactory : ICarFactory
{
    public ICar CreateCar() =>  new Sedan();
    public ICarSpecification CreateSpecification() => new NorthAmericaSpecification();
}
class EuropeCarFactory :ICarFactory
{
    public ICar CreateCar() => new Hatchback();

    public ICarSpecification CreateSpecification() => new EuropeSpecification();
}
