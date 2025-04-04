using System.ComponentModel;
// I have added a new animation called ShowLoadingDots(), and I change it instead of the spinner animation!
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Welldone !!");
        Thread.Sleep(3000);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStages = new List<string>();
        animationStages.Add("|");
        animationStages.Add("/");
        animationStages.Add("-");
        animationStages.Add("\\");
        animationStages.Add("/");
        animationStages.Add("-");

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStages[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStages.Count)
            {
                i = 0;
            }

        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void GetReady()
    {
        Console.WriteLine("Get Ready..");
        ShowLoadingDots(6);
        Console.WriteLine();
    }

    public void ShowLoadingDots(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int dotCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            dotCount++;

            if (dotCount > 3)
            {
                Console.Write("\b\b\b   \b\b\b"); // Clear the dots
                dotCount = 0;
            }

            Thread.Sleep(500);


        }
        Console.Write("\b\b\b   \b\b\b");
        Console.WriteLine();
    }
}