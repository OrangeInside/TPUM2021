using System;
using System.Collections.Generic;
using System.Text;
using ServerData;

namespace ServerLogic
{
    public class VinylObserver : IObserver<IVinyl>
    {
        private IDisposable disposableSubscriber = null;
        private Action<VinylDTO> onNext = null;

        public virtual void Subscribe(IObservable<IVinyl> provider, Action<VinylDTO> onNext)
        {
            this.onNext = onNext;

            if (provider != null)
            {
                disposableSubscriber = provider.Subscribe(this);
            }
        }
        public virtual void Unsubscribe()
        {
            disposableSubscriber?.Dispose();
        }

        public void OnCompleted()
        {
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {

        }

        public void OnNext(IVinyl value)
        {
            onNext?.Invoke(DTOMapper.Map(value));
        }
    }
}
