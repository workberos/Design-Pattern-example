namespace DesignPattern.CreationalPatterns.Builder;

public class Computer
{
    public string Name { private get; set; }
    public string Ram { private get; set; }
    public string Gpu { private get; set; }
    
    public void PrintComputerInfo() => Console.WriteLine($"Name: {Name}, ram: {Ram}, gpu: {Gpu}");
}