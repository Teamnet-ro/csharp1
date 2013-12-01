using System;

namespace Events
{
    // poa' să aibă parametri, ăsta n-are
    delegate void SomethingHappened();

    class Notifier
    {
        // event: din afară nu poți decît să subscrii și dezsubscrii
        public event SomethingHappened SomethingHappened;

        // field normal, toate funcționalitățile delegate
        // sunt disponibile oricui
        public SomethingHappened DelegateNotEvent;

        // se obișnuiește să fie protected
        protected void OnSomethingHappened()
        {
            // pattern ca nu cumva SomethindHappened
            // să devină null între cînd verific și cînd invoc
            var handler = SomethingHappened;
            if (handler != null)
            {
                handler();
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("I'm doing something");
            OnSomethingHappened();
        }
    }
}
