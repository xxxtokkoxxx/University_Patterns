using Patterns.Momento_Visitor.Visitor;

namespace Patterns.Momento_Visitor.Articles;

public class ShortReadArticle : Article, IComponent
{
    public ShortReadArticle(string name) : base(name)
    {
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitShortReadArticle(this);
    }

    public string GetShortReadArticleData()
    {
        return "Shortread article data";
    }
}