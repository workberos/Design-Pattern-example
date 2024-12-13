namespace DesignPattern.CreationalPatterns.AbstractFactory;

public static class UseAbstractFactory
{
    public static void Demo()
    {
        ICarFactory northAmericaFactory = new NorthAmericaCarFactory();
        var northAmericaCar = northAmericaFactory.CreateCar();
        var northAmericaSpec = northAmericaFactory.CreateSpecification();
        
        northAmericaCar.Assemble();
        northAmericaSpec.Display();

        Console.WriteLine(new string('-', 20));
        
        ICarFactory europeFactory = new EuropeCarFactory();
        var europeCar = europeFactory.CreateCar();
        var europeSpec = europeFactory.CreateSpecification();
        
        europeCar.Assemble();
        europeSpec.Display();
    }
}