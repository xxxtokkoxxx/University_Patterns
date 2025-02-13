using Patterns.Momento_Visitor.Articles;

namespace Patterns.Momento_Visitor.Momento;

public class Originator
{
    private Article _state;

    public Originator(Article state)
    {
        _state = state;
        Console.WriteLine("Originator: My initial state is: " + state);
    }

    public void CreateArticle(string name)
    {
        _state = new Article(name);
    }

    public IMemento Save()
    {
        return new ArticleMemento(_state);
    }

    public void Restore(IMemento memento)
    {
        _state = memento.GetState();
        Console.Write($"Originator: My state has changed to: {_state}");
    }
}