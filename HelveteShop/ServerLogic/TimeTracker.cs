using System;
using System.Collections.Generic;
using System.Text;

namespace ServerLogic
{
    public class TimeTracker : IObservable<float>
    {
        private List<IObserver<float>> observers;

        public TimeTracker()
        {
            observers = new List<IObserver<float>>();
        }

        public IDisposable Subscribe(IObserver<float> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new DisposableSubscriber(observers, observer);
        }

        public void ProcessTimeInterval(float timeInterval)
        {
            foreach (var obs in observers)
            {
                obs.OnNext(timeInterval);
            }
        }

        public void ClearConnection()
        {
            foreach (var obs in observers)
            {
                obs.OnCompleted();
            }

            observers.Clear();
        }

        private class DisposableSubscriber : IDisposable
        {
            private List<IObserver<float>> observers;
            private IObserver<float> observer;

            public DisposableSubscriber(List<IObserver<float>> observers, IObserver<float> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }

            public void Dispose()
            {
                if (observer != null && observers.Contains(observer))
                    observers.Remove(observer);
            }
        }
    }
}
