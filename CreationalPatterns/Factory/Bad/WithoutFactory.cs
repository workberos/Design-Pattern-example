namespace DesignPattern.CreationalPatterns.Factory.Bad;

public static class NotUseFactory
{
    public static void Demo()
    {
        Console.WriteLine("Bad solution :");
        var client = new Client(1);
        IVehicle? vehicle = client.GetVehicle();
        vehicle?.PrintVehicle();
        client.Cleanup();
        
        var client2 = new Client(2);
        IVehicle? vehicle2 = client2.GetVehicle();
        vehicle2?.PrintVehicle();
        client.Cleanup();
    }
}