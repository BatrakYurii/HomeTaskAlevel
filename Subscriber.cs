using System;

public class Subscriber
{
    public string Name { get; set; }
    public Subscriber(string name)
    {
        Name = name; 
    }

    public void Subscribe(Publisher publisher)
    {
        publisher.myEvent += Update;
    }

    public void Unsubscribe(Publisher publisher)
    {
        publisher.myEvent -= Update;
    }

    public void Update(object sender, EventArguments args)
    {
        Publisher publisher = (Publisher)sender;
        Console.WriteLine($"{publisher.Name} send a message : {args.Message}");
    }
}
