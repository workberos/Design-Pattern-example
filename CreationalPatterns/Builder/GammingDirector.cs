namespace DesignPattern.CreationalPatterns.Builder;

public class GammingDirector
{
    public Computer Construct(IComputerBuilder builder)
    {
        return builder
            .AddName("Gamming laptop")
            .AddGpu("Nvidia")
            .BuildRam("32")
            .Build();
    }
}