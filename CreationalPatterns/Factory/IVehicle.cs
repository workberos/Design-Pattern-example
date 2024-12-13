namespace DesignPattern.CreationalPatterns.Factory;

public interface IVehicle {
    void PrintVehicle();
}

class TwoWheeler : IVehicle
{
    public void PrintVehicle() => Console.WriteLine("Two Wheeler");
}

class FourWheeler : IVehicle
{
    public void PrintVehicle() => Console.WriteLine("Four Wheeler");
}