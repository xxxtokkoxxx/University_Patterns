using System.Collections;

namespace Patterns.State_Chain_Iterator.Iterator;

public class IteratorExample
{
    static void IteratorExampleTest()
    {
        UsersCollection collection = new UsersCollection();
        collection.AddItem(new User("Bob"));
        collection.AddItem(new User("John"));
        collection.AddItem(new User("Billy"));

        UserIterator iterator = (UserIterator) collection.GetEnumerator();

        foreach (User element in collection)
        {
            Console.WriteLine(element.Name);
        }
    }
}