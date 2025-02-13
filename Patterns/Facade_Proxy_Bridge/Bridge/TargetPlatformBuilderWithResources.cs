namespace Patterns.Facade_Proxy_Bridge.Bridge;

public class TargetPlatformBuilderWithResources : TargetPlatformBuilder
{
    public TargetPlatformBuilderWithResources(IPlatform platform) : base(platform)
    {
    }

    public override void Build()
    {
        Console.WriteLine("Load resources");
        base.Build();
    }
}