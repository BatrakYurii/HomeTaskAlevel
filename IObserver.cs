namespace master
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}