namespace master
{
    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Add(observerA);

            var observerB = new ConcreteObserverB();
            subject.Add(observerB);

            subject.SomeAction();
            subject.SomeAction();

            subject.Remove(observerB);

            subject.SomeAction();
        }
    }
}