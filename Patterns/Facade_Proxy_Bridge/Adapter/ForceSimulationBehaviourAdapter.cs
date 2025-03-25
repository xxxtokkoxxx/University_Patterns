namespace Patterns.Facade_Proxy_Bridge.Adapter;

public class ForceSimulationBehaviourAdapter
{
    private ForceSimulationBehaviour _forceSimulationBehaviour;

    public ForceSimulationBehaviourAdapter(ForceSimulationBehaviour forceSimulationBehaviour)
    {
        _forceSimulationBehaviour = forceSimulationBehaviour;
    }

    public void AddForce()
    {
        Console.WriteLine("Adding Force adaption");
        _forceSimulationBehaviour.AddForce();
    }
}