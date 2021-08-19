using System;

public class EventArguments : EventArgs
{
    public string Message { get; set; }
    public EventArguments(string message)
    {
        Message = message;
    }
}
