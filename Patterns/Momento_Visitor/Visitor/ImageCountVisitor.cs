using Patterns.Momento_Visitor.Articles;

namespace Patterns.Momento_Visitor.Visitor;

public class ImageCountVisitor : IVisitor
{
    public void VisitLongReadArticle(LongReadArticle article)
    {
        Console.WriteLine(article.GetLongReadArticleData() + " images count");
    }

    public void VisitShortReadArticle(ShortReadArticle article)
    {
        Console.WriteLine(article.GetShortReadArticleData() + " images count");
    }
}