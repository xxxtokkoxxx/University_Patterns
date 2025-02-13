using Patterns.Momento_Visitor.Articles;

namespace Patterns.Momento_Visitor.Momento;

public interface IMemento
{
    string GetName();

    Article GetState();
}