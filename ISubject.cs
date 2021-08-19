namespace master
{
    public interface ISubject
    {
        void Add(IObserver observer);

        void Remove(IObserver observer);

        void Notify();
    }
}