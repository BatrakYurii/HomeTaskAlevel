using System;

namespace master
{
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).Num < 3)
            {
                Console.WriteLine("ConcreteObserverA reacted");
            }
        }
    }
}