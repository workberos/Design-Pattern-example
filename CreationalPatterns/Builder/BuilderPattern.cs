namespace DesignPattern.CreationalPatterns.Builder;

public static class BuilderPattern
{
    public static void Demo()
    {
        var builder = new ComputerBuilder();
        var director = new GammingDirector();
        Computer pc = director.Construct(builder);

        var properties = pc.GetType().GetProperties();
        foreach (var property in properties)
        {
            Console.WriteLine($"{property.Name} : {property.GetValue(pc)}");
        }
    }
}