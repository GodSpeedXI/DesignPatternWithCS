using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPractice.IteratorPattern
{
    public static class IteratorTest
    {
        public static void Testing()
        {
            Console.WriteLine("Iterator Testing");
            var history = new BrowseHistory();
            history.push("a");
            history.push("b");
            history.push("c");

            var iteratorHistory = history.CreateIterator();

            while (iteratorHistory.HasNext())
            {
                Console.WriteLine("Url: {0}",iteratorHistory.Current());
                iteratorHistory.Next();
            }
        }
    }
}
