public class ListingActivity : Activity {
    private int _count ;
    private List<string> _prompts;
    public ListingActivity(string name, string description, int duration):base(name, description, duration) {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list\n as many things as you can in a certain area.";
        _duration = duration;
        _prompts = new List<string>() // Initialize with some example prompts
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
    }
    public void Run() {
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        GetReady();

        Console.WriteLine("List as many responses you can to the following prompt: ");

        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();


        List<string> responses = GetListFromUser();

        _count = responses.Count;
        
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine("Listing session complete!");
    }   
    public void GetRandomPrompt ()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        Console.WriteLine($" --- {randomPrompt} --- ");
    }
    public List<string> GetListFromUser(){
        List<string> userResponses = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now <= endTime)
        {
            Console.Write("-> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                userResponses.Add(response);
            }
        }

        return userResponses;
    }
}