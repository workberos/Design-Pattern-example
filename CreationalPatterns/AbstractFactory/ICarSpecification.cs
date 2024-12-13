namespace DesignPattern.CreationalPatterns.AbstractFactory;

public interface ICarSpecification
{
    void Display();
}

public class NorthAmericaSpecification : ICarSpecification
{
    public void Display() => Console.WriteLine("North America Car Specification");
}

public class EuropeSpecification : ICarSpecification
{
    public void Display() => Console.WriteLine("Europe Car Specification");
}