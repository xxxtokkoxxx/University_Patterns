using Patterns.Momento_Visitor.Visitor;

namespace Patterns.Momento_Visitor.Articles;

public class LongReadArticle : Article, IComponent
{
    public LongReadArticle(string name) : base(name)
    {
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitLongReadArticle(this);
    }

    public string GetLongReadArticleData()
    {
        return "Longread article data";
    }
}