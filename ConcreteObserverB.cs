using System;

namespace master
{
    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).Num == 0 || (subject as Subject).Num >= 2)
            {
                Console.WriteLine("ConcreteObserverB reacted");
            }
        }
    }
}