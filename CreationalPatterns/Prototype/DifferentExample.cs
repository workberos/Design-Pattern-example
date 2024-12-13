namespace DesignPattern.CreationalPatterns.Prototype;

public static class DifferentExample
{
    public static void Demo()
    {
        var userPrototype = new User()
        {
            Name = "John Doe",
            Age = 24
        };

        var user2 = userPrototype.Clone() as User;
        Console.WriteLine(user2?.Name);
    }
}

public class User : ICloneable
{
    public string Name { get; init; }
    public int Age { get; init; }
    public object Clone()
    {
        return (User) MemberwiseClone();
    }
}