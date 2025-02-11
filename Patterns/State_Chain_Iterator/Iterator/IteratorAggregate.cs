using System.Collections;

namespace Patterns.State_Chain_Iterator.Iterator;

public abstract class IteratorAggregate<T> : IEnumerable
{
    public abstract IEnumerator GetEnumerator();
    public abstract List<T> GetItems();
}