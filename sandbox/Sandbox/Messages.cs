public class Message
{
    public string _message;
    public int _priority;
    public string GetMessage()
    {
        return $"{_priority}: {_message}";
    }
    public void Display()
    {
        Console.WriteLine(GetMessage());
    }
}
/// Class diagram
/// [Message]
/// [_message: string,  _priority: int ]
/// [GetMessage(): string,   Display():void]