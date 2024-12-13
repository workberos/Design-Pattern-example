namespace DesignPattern.CreationalPatterns.Factory.Good;

public interface IVehicleFactory {
    IVehicle CreateVehicle();
}

public class TwoWheelerFactory : IVehicleFactory
{
    public IVehicle CreateVehicle() => new TwoWheeler();
}

public class FourWheelerFactory : IVehicleFactory
{
    public IVehicle CreateVehicle() => new FourWheeler();
}