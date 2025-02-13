using Patterns.Momento_Visitor.Articles;

namespace Patterns.Momento_Visitor.Visitor;

public class VisitorExample
{
    static void VisitorExampleMethod()
    {
        IVisitor wordCounter = new WordCountVisitor();
        IVisitor imageCounter = new ImageCountVisitor();

        List<IComponent> articles = new List<IComponent>()
        {
            new ShortReadArticle("Short"),
            new LongReadArticle("Long")
        };

        foreach (IComponent article in articles)
        {
            article.Accept(wordCounter);
            article.Accept(imageCounter);
        }
    }
}