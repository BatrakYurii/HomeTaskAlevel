namespace Master
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher("Publisher");
            Subscriber subscriber1 = new Subscriber("Subscriber1");
            Subscriber subscriber2 = new Subscriber("Subscriber2");
            Subscriber subscriber3 = new Subscriber("Subscriber3");

            subscriber1.Subscribe(publisher);
            subscriber2.Subscribe(publisher);
            subscriber3.Subscribe(publisher);

            publisher.Notify("Hello my Subscriber");

            subscriber2.Unsubscribe(publisher);

            publisher.Notify("This message will see only subscribers");
        }
    }
}
