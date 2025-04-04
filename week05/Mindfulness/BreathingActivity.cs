public class BreathingActivity : Activity {
    public BreathingActivity(string name, string description, int duration):base(name, description, duration) {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.";
        _duration = duration;
    }
    public void Run() {
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        
        GetReady();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(4);
            
            Console.WriteLine();
            Console.WriteLine(); // Add spacing
        }

        Console.WriteLine("Breathing session complete!");
    }
}