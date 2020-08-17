using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DesignPatternPractice.Middleware
{
    public static class PipeConceptTest
    {
        public static void Run()
        {
            var pipe = new PipeBuilder(First)
                .AddPipe<Wrapper2>()
                .AddPipe<Wrapper>()
                .AddPipe<Wrapper2>()
                .Build();

            pipe("Execute1");
            pipe("Execute2");
            pipe("Execute3");
        }

        private static void First(string msg)
        {
            $"First Executing {msg}".Dump();
        }

        private static void Second(string msg)
        {
            $"Second Executing {msg}".Dump();
        }
    }
    /// <summary>
    /// Abstract class is similar to interface but abstract can impose some signature to the class
    /// not only method or prop
    /// </summary>
    public abstract class APipe
    {
        protected Action<string> _action;

        public APipe(Action<string> action)
        {
            _action = action;
        }
        public abstract void Handel(string msg);
    }

    public class Wrapper : APipe
    {
        public Wrapper(Action<string> action) : base(action) { }
        public override void Handel(string msg)
        {
            "Wrapping start".Dump();
            _action(msg);
            "End Wrapping".Dump();
        }
    }

    public class Wrapper2 : APipe
    {
        public Wrapper2(Action<string> action) : base(action) { }
        public override void Handel(string msg)
        {
            "Wrapping2 start".Dump();
            _action(msg);
            "End Wrapping2".Dump();
        }
    }

    public class PipeBuilder
    {
        private Action<string> _mainAction;
        private List<Type> _pipeTypes;
        public PipeBuilder(Action<string> mainAction)
        {
            _mainAction = mainAction;
            _pipeTypes = new List<Type>();
        }

        public PipeBuilder AddPipe<T>() where T : APipe
        {
            //if (T.BaseType != null && !(T.BaseType == typeof(APipe)))
            //{
            //    throw new Exception("Not correct type.");
            //}

            _pipeTypes.Add(typeof(T));
            return this;
        }

        private Action<string> CreatePipe(int index)
        {
            if (index < _pipeTypes.Count - 1)
            {
                var childPipeHandle = CreatePipe(index + 1);
                var pipe = (APipe)Activator.CreateInstance(_pipeTypes[index], childPipeHandle);
                return pipe.Handel;
            }
            else
            {
                var finalPipe = (APipe)Activator.CreateInstance(_pipeTypes[index], _mainAction);
                return finalPipe.Handel;
            }
        }

        public Action<string> Build()
        {
            return CreatePipe(0);
        }
    }
}
