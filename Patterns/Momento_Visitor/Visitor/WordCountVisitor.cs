using Patterns.Momento_Visitor.Articles;

namespace Patterns.Momento_Visitor.Visitor;

public class WordCountVisitor : IVisitor
{
    public void VisitLongReadArticle(LongReadArticle article)
    {
        Console.WriteLine(article.GetLongReadArticleData() + " words count");
    }

    public void VisitShortReadArticle(ShortReadArticle article)
    {
        Console.WriteLine(article.GetShortReadArticleData() + " words count");
    }
}