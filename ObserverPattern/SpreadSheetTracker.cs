using System;
using System.Collections.Generic;

namespace DesignPatternPractice.ObserverPattern
{
    public class SpreadSheetTracker : IObservable<SpreadSheetModel>
    {
        private List<IObserver<SpreadSheetModel>> _observers;

        public SpreadSheetTracker()
        {
            _observers = new List<IObserver<SpreadSheetModel>>();
        }

        public void TrackSpreadSheet(SpreadSheetModel? locModel)
        {
            foreach (var observer in _observers)
            {
                if (!locModel.HasValue)
                    observer.OnError(new Exception());
                else
                    observer.OnNext(locModel.Value);
            }
        }

        public IDisposable Subscribe(IObserver<SpreadSheetModel> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new Unsubscribe(_observers, observer);
        }

        private class Unsubscribe : IDisposable
        {
            private List<IObserver<SpreadSheetModel>> _uObservers;
            private IObserver<SpreadSheetModel> _uObserver;
            public Unsubscribe(List<IObserver<SpreadSheetModel>> observers, IObserver<SpreadSheetModel> observer)
            {
                this._uObservers = observers;
                this._uObserver = observer;
            }
            public void Dispose()
            {
                if (_uObserver != null && _uObservers.Contains(_uObserver))
                    _uObservers.Remove(_uObserver);
            }
        }

        public void EndTransmission()
        {
            foreach (var observer in _observers.ToArray())
                if (_observers.Contains(observer))
                    observer.OnCompleted();

            _observers.Clear();
        }
    }
}
