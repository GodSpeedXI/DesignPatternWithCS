using System;
using DesignPatternPractice.CommandPattern;
using DesignPatternPractice.IteratorPattern;
using DesignPatternPractice.MementoPattern;
using DesignPatternPractice.Middleware;
using DesignPatternPractice.ObserverPattern;
using DesignPatternPractice.StategyPattern;
using DesignPatternPractice.StatePattern;
using DesignPatternPractice.TemplateMethodPattern;

namespace DesignPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            MementoTest.Testing();
            Hr();
            StateTest.Testing();
            Hr();
            IteratorTest.Testing();
            Hr();
            DelegateMiddlewareEx.Run();
            Hr();
            ActionFunc.Run();
            Hr();
            PipeConceptTest.Run();
            Hr();
            StategyPatternTest.Run();
            Hr();
            TemplateMethodTest.Run();
            Hr();
            CommandPatternTest.Run();
            Hr();
            ObserverPatternTest.Run();
        }

        static void Hr()
        {
            "==================".Dump();
        }
    }
}
