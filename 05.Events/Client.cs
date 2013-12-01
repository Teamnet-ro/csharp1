using System;

namespace Events
{
    class Client
    {
        public Client(Notifier notifier)
        {
            notifier.SomethingHappened += NotifierOnSomethingHappened;
        }

        private void NotifierOnSomethingHappened()
        {
            Console.WriteLine("Something happened");
        }
    }

    class BadClient
    {
        public BadClient(Notifier notifier)
        {
            notifier.DelegateNotEvent = NotifierDelegateInvoked;
        }

        private void NotifierDelegateInvoked()
        {
            Console.WriteLine("The delegate was invoked");
        }
    }
}
