namespace DesignPattern.CreationalPatterns.Factory.Bad;

class Client
{
    /*
     * 1. Strong dependency makes the code hard to maintain or update.
     * 2. Must modify the Adapter class when add new IVehicle
     * 
     */
    public Client(int type)
    {
        _vehicle = type switch
        {
            1 => new TwoWheeler(),
            2 => new FourWheeler(),
            _ => null
        };
    }
    private IVehicle? _vehicle;

    public void Cleanup() {
        if (_vehicle != null) 
            _vehicle = null;
    }
    public IVehicle? GetVehicle() => _vehicle;   
}