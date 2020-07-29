using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPractice.Middleware
{
    /// <summary>
    /// Example how to use delegate function as a middleware.
    /// </summary>
    public static class DelegateMiddlewareEx
    {
        public static void Run() 
        {
            TryDelegate(Delefunc1);
            TryDelegate(Delefunc2);
        }

        /// <summary>
        /// Delegate is similar to interface but in the kind of function.
        /// </summary>
        delegate void ToDelegateFunc(string msg);

        private static void Delefunc1(string msg) {
            Console.WriteLine("Delefunc1 called!! with msg " + msg);
        }
        private static void Delefunc2(string msg)
        {
            Console.WriteLine("Delefunc2 called!! with msg " + msg);
        }

        private static void TryDelegate(ToDelegateFunc dgFuct) 
        {
            dgFuct("nice!");
        }


    }
}
