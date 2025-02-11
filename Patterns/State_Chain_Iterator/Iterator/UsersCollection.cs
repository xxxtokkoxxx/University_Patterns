using System.Collections;

namespace Patterns.State_Chain_Iterator.Iterator;

public class UsersCollection : IteratorAggregate<User>
{
    private List<User> _collection = new();
    public override List<User> GetItems()
    {
        return _collection;
    }

    public void AddItem(User item)
    {
        _collection.Add(item);
    }

    public override IEnumerator GetEnumerator()
    {
        return new UserIterator(this);
    }
}