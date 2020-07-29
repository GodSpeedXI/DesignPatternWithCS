using System;

namespace DesignPatternPractice.Middleware
{
    public static class ActionFunc
    {
        public static void Run()
        {
            Wrap("N1", Action1);
            Wrap("N2", Action2);

            // These a kind of middleware you can execute whether tryfirst or trysecond as first call.
            TryActionFirst(() => { TryActionSecond(First); });
            TryActionSecond(()=>{ TryActionFirst(Second); });
            "=================".Dump();

            // These a use case of pipe.
            Action<string> pipe = (msg) => 
                TryActionFirst(msg, (msg) =>
                    TryActionSecond(msg, First));

            pipe("Holly Shit");
        }

        private static void Action1(string msg)
        {
            $"Action1 Executing {msg}".Dump();
        }

        private static void Action2(string msg)
        {
            $"Action2 Executing {msg}".Dump();
        }

        private static void Wrap(string msg, Action<string> fucn)
        {
            Console.WriteLine("Start " + msg);
            fucn(msg);
            Console.WriteLine("End " + msg);
        }

        private static void TryActionFirst(Action func)
        {
            ("Trying First").Dump();
            func();
        }

        private static void TryActionFirst(string msg ,Action<string> func)
        {
            ("Trying First").Dump();
            func(msg);
        }

        private static void TryActionSecond(Action func)
        {
            ("Trying Second").Dump();
            func();
        }

        private static void TryActionSecond(string msg, Action<string> func)
        {
            ("Trying Second").Dump();
            func(msg);
        }

        private static void First()
        {
            "Execution First Function".Dump();
        }

        private static void First(string msg)
        {
            ("Execution First Function with msg = " + msg).Dump();
        }

        private static void Second()
        {
            "Execution Second Function".Dump();
        }

        private static void Second(string msg)
        {
            ("Execution Second Function with msg = " + msg).Dump();
        }
    }
}
