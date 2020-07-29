using System;
using DesignPatternPractice.IteratorPattern;
using DesignPatternPractice.MementoPattern;
using DesignPatternPractice.Middleware;
using DesignPatternPractice.StatePattern;

namespace DesignPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //MementoTest.Testing();
            //Hr();
            //StateTest.Testing();
            //Hr();
            //IteratorTest.Testing();
            //Hr();
            DelegateMiddlewareEx.Run();
            Hr();
            ActionFunc.Run();
        }

        static void Hr()
        {
            Console.WriteLine("==================");
        }
    }
}
