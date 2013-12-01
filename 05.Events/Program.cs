using System;

namespace Events
{
    class Program
    {
        static void Main()
        {
            var notifier = new Notifier();
            var client = new Client(notifier);

            notifier.DoSomething();

            var badClient = new BadClient(notifier);
            notifier.DelegateNotEvent.Invoke();
        }
    }
}
