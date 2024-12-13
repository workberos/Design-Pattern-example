namespace DesignPattern.CreationalPatterns.Builder;

public interface IComputerBuilder
{
    IComputerBuilder AddName(string name);
    IComputerBuilder BuildRam(string ram);
    IComputerBuilder AddGpu(string gpu);
    Computer Build();
}

public class ComputerBuilder : IComputerBuilder
{
    private readonly Computer _computer = new();
    
    public IComputerBuilder AddName(string name)
    {
        _computer.Name = name;
        return this;
    }

    public IComputerBuilder BuildRam(string ram)
    {
        _computer.Ram = ram;
        return this;
    }

    public IComputerBuilder AddGpu(string gpu)
    {
        _computer.Gpu = gpu;
        return this;
    }
    public Computer Build() => _computer;
}