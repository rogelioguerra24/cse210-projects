public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = duration;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public void Run()
    {
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        GetReady();

        Console.WriteLine("Consider the following prompt: ");

        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.Clear();
        while (DateTime.Now <= endTime)
        {
            DisplayQuestions();
        }
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        return $" --- {randomPrompt} ---";
    }
    public string GetRandomQuestions()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string randomQuestion = _questions[index];

        return $"-> {randomQuestion} ";
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestions()
    {
        Console.Write(GetRandomQuestions());
        ShowSpinner(10);
        Console.WriteLine();
    }
}