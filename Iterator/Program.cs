using Iterator.Items_to_iterate;
using Iterator.Iterator;
using System;

namespace Iterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arrayCollection = new ArrayItem();
            var standardizedArray = arrayCollection.CreateIterator();

            var listCollection = new ListItem();
            var standardizedList = listCollection.CreateIterator();

            PrintItems(standardizedArray);
            PrintItems(standardizedList);
        }

        static void PrintItems(IIterator iterator)
        {
            while (!iterator.IsDone())
            {
                Console.WriteLine($"Current item is {iterator.CurrentItem()}");
                iterator.Next();
            }
        }
    }
}
