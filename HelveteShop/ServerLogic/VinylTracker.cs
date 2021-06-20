using System;
using System.Collections.Generic;
using System.Text;
using ServerData;

namespace ServerLogic
{
    public class VinylTracker : IObservable<IVinyl>
    {
        private readonly List<IObserver<IVinyl>> observers;

        public VinylTracker()
        {
            observers = new List<IObserver<IVinyl>>();
        }

        public IDisposable Subscribe(IObserver<IVinyl> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }

            return new DisposeSubscriber(observers, observer);
        }

        public void Track(IVinyl vinyl)
        {
            foreach (var o in observers)
            {
                if (vinyl == null)
                {
                    o.OnError(new Exception("Error with vinyl"));
                }
                else
                {
                    o.OnNext(vinyl);
                }
            }
        }

        public void End()
        {
            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }

            observers.Clear();
        }

        private class DisposeSubscriber : IDisposable
        {
            private readonly List<IObserver<IVinyl>> observers;
            private readonly IObserver<IVinyl> observer;

            public DisposeSubscriber(List<IObserver<IVinyl>> observers, IObserver<IVinyl> observer)
            {
                this.observer = observer;
                this.observers = observers;
            }

            public void Dispose()
            {
                if (observer != null && observers.Contains(observer))
                    observers.Remove(observer);
            }
        }
    }
}
