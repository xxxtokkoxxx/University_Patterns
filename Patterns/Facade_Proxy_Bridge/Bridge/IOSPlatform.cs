namespace Patterns.Facade_Proxy_Bridge.Bridge;

public class IOSPlatform : IPlatform
{
    public void Build()
    {
        Console.WriteLine("Build iOS");
    }
}