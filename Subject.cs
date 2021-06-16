using System;
using System.Collections.Generic;
using System.Threading;

namespace master
{
    public class Subject : ISubject
    {
        public int Num { get; set; } = 0;

        private List<IObserver> _observers = new List<IObserver>();

        public void Add(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            _observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
        public void SomeAction()
        {
            Console.WriteLine("\nSubject do some action");
            this.Num = new Random().Next(0, 7);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + this.Num);
            this.Notify();
        }
    }
}