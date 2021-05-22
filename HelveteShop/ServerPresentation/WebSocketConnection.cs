using System;
using System.Threading.Tasks;

namespace ServerPresentation
{
    public abstract class WebSocketConnection
    {
        public virtual Action<string> onMessage { set; protected get; } = x => { };
        public virtual Action onClose { set; protected get; } = () => { };
        public virtual Action onError { set; protected get; } = () => { };

        protected abstract Task SendTask(string message);

        public async Task SendAsync(string message)
        {
            await SendTask(message);
        }

        public abstract Task Disconnect();

    }
}
