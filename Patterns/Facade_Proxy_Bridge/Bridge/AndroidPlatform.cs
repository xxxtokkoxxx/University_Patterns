namespace Patterns.Facade_Proxy_Bridge.Bridge;

public class AndroidPlatform : IPlatform
{
    public void Build()
    {
        Console.WriteLine("Build android");
    }
}