using System.Collections;

namespace Patterns.State_Chain_Iterator.Iterator;

public abstract class Iterator<T> : IEnumerator<T>
{
    public abstract int Key();
    public abstract bool MoveNext();
    public abstract void Reset();
    object? IEnumerator.Current => Current;

    public abstract T Current { get; }
    public abstract void Dispose();
}