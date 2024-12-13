namespace DesignPattern.CreationalPatterns.Factory.Good;

public class Client
{
    private readonly IVehicle _vehicle;

    public Client(IVehicleFactory vehicleFactory)
    {
        _vehicle = vehicleFactory.CreateVehicle();
    }
    public IVehicle GetVehicle() => _vehicle;
}