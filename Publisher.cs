using System;

public class Publisher
{
    public string Name { get; set; }
    public Publisher(string name)
    {
        Name = name;
    }

    public event EventHandler<EventArguments> myEvent;

    public void Notify(string message)
    {
        EventArguments args = new EventArguments(message);
        if (myEvent != null)
            myEvent(this, args);
    }
}
