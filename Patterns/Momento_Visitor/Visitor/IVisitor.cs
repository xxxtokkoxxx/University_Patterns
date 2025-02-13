using Patterns.Momento_Visitor.Articles;

namespace Patterns.Momento_Visitor.Visitor;

public interface IVisitor
{
    void VisitLongReadArticle(LongReadArticle article);
    void VisitShortReadArticle(ShortReadArticle article);
}