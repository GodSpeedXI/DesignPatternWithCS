using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPractice.ObserverPattern
{
    public class SpreadSheetReporter : IObserver<SpreadSheetModel>
    {
        private IDisposable unsubscriber;
        private string _instName;
        public string Name
        { get { return _instName; } }

        public SpreadSheetReporter(string instName)
        {
            _instName = instName;
        }
        public virtual void Subscribe(IObservable<SpreadSheetModel> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }
        public virtual void OnCompleted()
        {
            $"SpreadSheet tracker has completed to {Name}".Dump();
        }

        public virtual void OnError(Exception error)
        {
            $"{this.Name} : SpreadSheet cannot be determined.".Dump();
        }

        public virtual void OnNext(SpreadSheetModel value)
        {
            $"SpreadSheet is Added into Instant: {Name}, Content: {value.Content}, CreatedAt: {value.CreateDate}".Dump();
        }
    }
}
