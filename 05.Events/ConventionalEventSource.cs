using System;

namespace Events
{
    class ConventionalEventSource
    {
        public event EventHandler SomethingHappened;

        public event EventHandler<MyEventArgs> JesusCame;

        protected void OnSomethingHappened()
        {
            var handler = SomethingHappened;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        protected void OnJesusCame(string message)
        {
            var handler = JesusCame;
            if (handler != null)
                handler(this, new MyEventArgs(message));
        }
    }

    class MyEventArgs : EventArgs
    {
        private readonly string message;

        public MyEventArgs(string message)
        {
            this.message = message;
        }

        public string Message
        {
            get { return message; }
        }
    }
}
