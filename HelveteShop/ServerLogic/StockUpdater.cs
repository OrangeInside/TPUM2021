using System;
using System.Collections.Generic;
using System.Text;

namespace ServerLogic
{
    public class StockUpdater : IObserver<float>
    {
        private IDisposable disposeSubscriber = null;

        private float timeToUpdateStock = 5.0f;
        private float currentTime = 0.0f;

        private Action updateStock = null;

        public void Subscribe(IObservable<float> contractor, Action onUpdateStock)
        {
            updateStock += onUpdateStock;

            if (contractor != null)
            {
                disposeSubscriber = contractor.Subscribe(this);
            }
        }

        public void OnCompleted()
        {
            Unsubscribe();
        }

        public void OnError(Exception error)
        {
            
        }

        public void OnNext(float value)
        {
            currentTime += value;

            if (currentTime >= timeToUpdateStock)
            {
                currentTime = 0.0f;
                updateStock?.Invoke();
            }
        }

        public void Unsubscribe()
        {
            disposeSubscriber?.Dispose();
        }
    }
}
