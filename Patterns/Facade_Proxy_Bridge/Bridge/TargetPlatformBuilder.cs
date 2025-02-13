namespace Patterns.Facade_Proxy_Bridge.Bridge;

public class TargetPlatformBuilder
{
    private IPlatform _platform;

    public TargetPlatformBuilder(IPlatform platform)
    {
        _platform = platform;
    }

    public virtual void Build()
    {
        _platform.Build();
        Console.WriteLine("Create base builder");
    }
}