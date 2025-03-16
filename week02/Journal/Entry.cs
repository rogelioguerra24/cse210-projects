public class Entry 
{
    public string _date;
    public string _prompText;
    public string _entryText;
    public string _hour;
    public void Display ()
    {
        Console.WriteLine($"Date: {_date} - Hour: {_hour} - Prompt: {_prompText}");
        Console.WriteLine(_entryText);
        Console.WriteLine("");
    }
}