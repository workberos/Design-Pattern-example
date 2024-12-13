namespace DesignPattern.CreationalPatterns.Prototype;

public interface IShape
{
    IShape Clone();
    void Draw();
}

public class Circle : IShape
{
    private readonly string _color;
    public Circle(string color)
    {
        this._color = color;
    }
    public IShape Clone() => new Circle(_color);
    public void Draw() => Console.WriteLine("Drawing a " + _color + " circle.");
    
}