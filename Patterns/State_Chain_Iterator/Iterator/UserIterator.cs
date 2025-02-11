namespace Patterns.State_Chain_Iterator.Iterator;

public class UserIterator : Iterator<User>
{
    private readonly IteratorAggregate<User> _iteratorAggregate;

    public UserIterator(IteratorAggregate<User> iteratorAggregate)
    {
        _iteratorAggregate = iteratorAggregate;
    }

    private int _position = -1;

    public override int Key()
    {
        return _position;
    }

    public override bool MoveNext()
    {
        int updatedPosition = _position + 1;

        if (updatedPosition >= 0 && updatedPosition < _iteratorAggregate.GetItems().Count)
        {
            _position = updatedPosition;
            return true;
        }

        return false;
    }

    public override void Reset()
    {
        _position = 0;
    }

    public override User Current => _iteratorAggregate.GetItems()[_position];

    public override void Dispose() { }
}