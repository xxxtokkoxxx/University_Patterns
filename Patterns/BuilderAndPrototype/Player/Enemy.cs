namespace Patterns.BuilderAndPrototype.Player;

public class Enemy : ICloneable
{
    public object Clone()
    {
        Enemy clone = (Enemy)MemberwiseClone();
        return clone;
    }
}