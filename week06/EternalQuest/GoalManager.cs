using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
using System.IO;
using System.Formats.Asn1;
public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int _score;

    public void Start()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");
        Console.Write("Select a choice of the menu: ");
    }
    public void DisplayPlayerInfo()
    {
        string status = "";

        if(_score < 500){status = "Lazy Boy";}
        else if(_score < 1000){status = "Begginer";}
        else if(_score < 1500){status = "Intermediate";}
        else if(_score < 2000){status = "Advanced";}
        else if(_score < 2500){status = "Pro";}
        else if(_score < 3000){status = "Advanced";}
        else{status = "Legendary";}

        RandomCounselMessage message = new RandomCounselMessage(); // To call the messageGenerator function
        message._message.Add("You are stronger than you think — keep moving forward.");
        message._message.Add("God is not done with you yet. Greater things are coming.");
        message._message.Add("Even in silence, He is working on your behalf.");
        message._message.Add("Your story isn't over — it's just beginning.");
        message._message.Add("Peace comes when you trust the process.");
        message._message.Add("You were made with purpose, for a purpose.");
        message._message.Add("Let your faith be bigger than your fear.");
        message._message.Add("You are not alone — He walks beside you.");
        message._message.Add("Small steps of faith lead to great victories.");
        message._message.Add("You are chosen, loved, and called.");
        message._message.Add("Every day is a fresh start filled with grace.");
        message._message.Add("Strength grows in the waiting.");
        message._message.Add("He restores what was broken.");
        message._message.Add("Don’t give up — the breakthrough is near.");
        message._message.Add("Grace covers you today and always.");
        message._message.Add("When you can’t see the way, trust the One who leads.");
        message._message.Add("Faith isn't about having all the answers — it's about trusting the One who does.");
        message._message.Add("You're not behind — you're being prepared.");
        message._message.Add("God's timing is always perfect — never late.");
        message._message.Add("You are light in this world — shine boldly.");

        Console.WriteLine();
        Console.WriteLine($"Your score is {_score} points");
        Console.WriteLine($"Status: {status}");
        Console.WriteLine($"Motivation Message: {message.GetRandomMessage()}");
        Console.WriteLine();


    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goal are: ");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");

        Console.Write("Which type of goal would like to create? ");
        int goalType = int.Parse(Console.ReadLine());
        Console.Write("What is the name of the goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();

        if (goalType == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, false);
            goals.Add(simpleGoal);
        }
        if (goalType == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            goals.Add(eternalGoal);
        }
        if (goalType == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalTarget = int.Parse(Console.ReadLine()); // target first
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());
            CheckListGoal checkListGoal = new CheckListGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus, 0);
            goals.Add(checkListGoal);
        }
    }
    public void ListGoalNames()
    {
        int listCount = 1; // Start from 1, so we have meaningful list numbering
        if (goals.Count != 0)
        {
            
        foreach (Goal goal in goals)
            {
                string[] details = goal.GetStringRepresentation().Split(",");
                string name = "";
                string checkbox = "[ ]";
                string description = "";

                if (details.Length == 5)
                {
                    name = details[1];
                    description = $"({details[2]})";
                    bool isComplete = bool.Parse(details[4]);
                    checkbox = isComplete ? "[X]" : "[ ]";
                }
                else if (details.Length == 4)
                {
                    name = details[1];
                    description = $"({details[2]})";
                }
                else if (details.Length == 7)
                {
                    name = details[1];
                    description = $"({details[2]})";
                    string target = details[5];
                    string amountCompleted = details[6];
                    checkbox = target == amountCompleted ? "[X]" : "[ ]";
                    description += $" -- Currently completed: {amountCompleted}/{target}";
                }

                Console.WriteLine($"  {listCount}. {checkbox} {name} {description}");
                
                listCount++;}
                }
                else
                {
                    Console.WriteLine("There are no goals at this moment.");
                }
    }
    public void ListGoalsDetails()
    {
        if (goals.Count != 0)
        {
            
            foreach (Goal goal in goals)
            {
                string[] details = goal.GetStringRepresentation().Split(",");

                if (details.Length == 5)
                {
                    string description = details[2];
                    Console.WriteLine($"({description})");
                }
                else if (details.Length == 4)
                {
                    string description = details[2];
                    Console.WriteLine($"({description})");
                }
                else if (details.Length == 7)
                {
                    string description = details[2];
                    string target = details[5];
                    string amountCompleted = details[6];

                    Console.WriteLine($"({description}) -- Currently completed: {amountCompleted}/{target}");
                }
            }
        }
        else
        {
            Console.WriteLine("There are no goals at this moment.");
        }
    }

    public void RecordEvent()
    {
        Console.Write($"Which goal did you accomplish? ");
        int goalElection = int.Parse(Console.ReadLine());
        Goal choosenGoal = goals[goalElection-1];
        string[] stringData = choosenGoal.GetStringRepresentation().Split(",");
        int points = int.Parse(stringData[3]);
        

        if (stringData.Length == 5)
        {
            bool completed = bool.Parse(stringData[4]);
            if (completed == false)
            {
                int points1 = int.Parse(stringData[3]);
                _score += points1;
                choosenGoal.RecordEvent();
            }
            else
            {
                Console.WriteLine("You have already acomplished this goal");
            }
        }
        if (stringData.Length == 4)
        {
            choosenGoal.IsComplete();
            int points2 = int.Parse(stringData[3]);
            _score += points2;
            choosenGoal.RecordEvent();
        }

        if (stringData.Length == 7)
        {   
            int completed = int.Parse(stringData[6]);
            int target = int.Parse(stringData[5]);
            int bonus = int.Parse(stringData[4]);

             if (completed == target-1)
                {
                    _score += bonus;
                }

            if (choosenGoal.IsComplete() == false)
            {


                _score += points;


                choosenGoal.RecordEvent();
            }

            else
            {

                Console.WriteLine("You have already acomplished this goal");
            }
        }

       
    }
    public void SaveGoals(string fileName) {
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            foreach(Goal goal in goals){
                outputFile.WriteLine($"{_score},{goal.GetStringRepresentation()}");
            }
        }
    }
    public void LoadGoals(string fileName) {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines){
            string[] parts = line.Split(",");
            int score = int.Parse(parts[0]);
            string shortName = parts[2];
            string description = parts[3];
            string points = parts[4];

            if(parts.Length == 6) {
                bool isComplete = bool.Parse(parts[5]);
                SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points, isComplete);
                goals.Add(simpleGoal);
            }
            if(parts.Length == 5) {
                EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
                goals.Add(eternalGoal);
            }
            if(parts.Length == 8) {
                int bonus = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);
                int completedAmount = int.Parse(parts[7]);
                CheckListGoal checkListGoal = new CheckListGoal(shortName, description, points, target, bonus, completedAmount);
                goals.Add(checkListGoal);
            }
            _score = score;
        }
        


    }
}