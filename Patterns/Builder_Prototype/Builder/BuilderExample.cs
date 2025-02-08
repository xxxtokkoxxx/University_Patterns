namespace Patterns.Builder_Prototype.Builder;

public class BuilderExample
{
    public void Test()
    {
        IDirector director = new Director();

        director.CreateMage();
        director.CreateMercenary();
        director.CreateWarrior();
        director.CreateBattleMage();
    }
}