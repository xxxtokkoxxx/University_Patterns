using Patterns.Momento_Visitor.Articles;

namespace Patterns.Momento_Visitor.Momento;

public class MomentoExample
{
    static void MomentoExampleMethod()
    {
        // Client code.
        Originator originator = new Originator(new Article("Test"));
        Caretaker caretaker = new Caretaker(originator);

        caretaker.Backup();
        originator.CreateArticle("test2");

        caretaker.Backup();
        originator.CreateArticle("test3");

        caretaker.ShowHistory();

        caretaker.Undo();
        caretaker.Undo();
    }
}