using Patterns.Momento_Visitor.Articles;

namespace Patterns.Momento_Visitor.Momento;

public class ArticleMemento : IMemento
{
    private Article _state;


    public ArticleMemento(Article state)
    {
        _state = state;
    }

    public string GetName()
    {
        return _state.Name;
    }

    public Article GetState()
    {
        return _state;
    }
}