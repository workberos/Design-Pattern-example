namespace DesignPattern.CreationalPatterns.AbstractFactory;

public interface ICar
{
    void Assemble();
}

public class Hatchback : ICar
{
    public void Assemble() => Console.WriteLine("Assembling Hatchback car.");
}

public class Sedan : ICar
{
    public void Assemble() => Console.WriteLine("Assembling Sedan car.");
}