namespace DesignPattern.CreationalPatterns.Prototype;

public class ShapeClient
{
    private readonly IShape _shapePrototype;

    public ShapeClient(IShape shapePrototype)
    {
        this._shapePrototype = shapePrototype;
    }
    public IShape CreateShape() => _shapePrototype.Clone();
}