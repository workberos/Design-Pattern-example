namespace DesignPattern.CreationalPatterns.Factory.Good;

public static class UseFactory
{
    /*
     * Solution:
     *  - Define a Factory Interface
     *  - Create Specific Factories: TwoWheelerFactory, FourWheelerFactory
     *  - Adapter use a VehicleFactory instance instead of creating vehicles directly
     */
    public static void Demo()
    {
        Console.WriteLine("\nGood solution :\n");

        var twoWheelerFactory = new TwoWheelerFactory();
        var twoWheelerClient = new Client(twoWheelerFactory);
        IVehicle twoWheelerVehicle = twoWheelerClient.GetVehicle();
        
        var fourWheelerFactory = new FourWheelerFactory();
        var fourWheelerClient = new Client(fourWheelerFactory);
        IVehicle fourWheelerVehicle = fourWheelerClient.GetVehicle();
        
        twoWheelerVehicle.PrintVehicle();
        fourWheelerVehicle.PrintVehicle();
    }
}