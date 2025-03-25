namespace Patterns.Facade_Proxy_Bridge.Adapter;

public class AdapterExample
{
    public void Test()
    {
        ForceSimulationBehaviour adaptee = new ForceSimulationBehaviour();
        adaptee.AddForce();
        ForceSimulationBehaviourAdapter adapter = new ForceSimulationBehaviourAdapter(adaptee);
        adapter.AddForce();
    }
}