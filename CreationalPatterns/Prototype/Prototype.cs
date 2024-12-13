namespace DesignPattern.CreationalPatterns.Prototype;

public static class Prototype
{
    public static void Demo()
    {
        // Create a concrete prototype (a red circle).
        IShape circlePrototype = new Circle("Red");
        
        // Create a client and give it the prototype.
        var client = new ShapeClient(circlePrototype);
        
        // Use the prototype to create a new shape (a red circle).
        IShape redCircle = client.CreateShape();
        redCircle.Draw();
    }
}