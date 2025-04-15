using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine();

        List<Activity> activities = new List<Activity>();

        Running running = new Running(30, 4.8);
        StationaryBycicles stationaryBycicles = new StationaryBycicles(30, 9.7);
        Swimmming swimmming = new Swimmming(30, 6.25);

        activities.Add(running);
        activities.Add(stationaryBycicles);
        activities.Add(swimmming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"°{activity.GetSummary()}");
        }
        Console.WriteLine();
    }
}