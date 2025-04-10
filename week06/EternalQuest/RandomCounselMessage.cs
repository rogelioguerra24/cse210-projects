
public class RandomCounselMessage
{
    public List<string> _message = new List<string>();
    public string GetRandomMessage ()
    {
        Random random = new Random();
        int index = random.Next(_message.Count);
        string randomMessage = _message[index];

        return randomMessage;
    }
}