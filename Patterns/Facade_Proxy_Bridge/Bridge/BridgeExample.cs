namespace Patterns.Facade_Proxy_Bridge.Bridge;

public class BridgeExample
{
    public void BridgeExampleMethod()
    {
        TargetPlatformBuilder targetPlatformBuilder = new TargetPlatformBuilder(new AndroidPlatform());
        targetPlatformBuilder.Build();
        targetPlatformBuilder = new TargetPlatformBuilder(new IOSPlatform());
        targetPlatformBuilder.Build();
        targetPlatformBuilder = new TargetPlatformBuilderWithResources(new IOSPlatform());
        targetPlatformBuilder.Build();
    }
}