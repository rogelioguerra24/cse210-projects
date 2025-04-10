using System;
/*I have added clasification or an status for the user when he begin and when he is advancing in the score
and I added Motivational Messages for the user to don't give up and remember who is he or she*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        
        int userOption = 0 ;
        GoalManager goalManager = new GoalManager();
        while (userOption != 6) {
            goalManager.DisplayPlayerInfo();
            goalManager.Start();

            string userOptions = Console.ReadLine();
            
            if (userOptions == "1") {
                goalManager.CreateGoal();
            }
            if (userOptions == "2") {
                Console.WriteLine("The goals are: ");
                
                goalManager.ListGoalNames();
                
            }
            if (userOptions == "3") {
                Console.Write("What is the filename for goals file? ");
                string fileName = Console.ReadLine();
                goalManager.SaveGoals(fileName);
            }
            if (userOptions == "4") {
                Console.Write("What is the filename for goal file? ");
                string fileName = Console.ReadLine();
                goalManager.LoadGoals(fileName);
            }
            if (userOptions == "5") {
                goalManager.ListGoalNames();
                goalManager.RecordEvent();
            }
            if (userOptions == "6") {
                userOption = 6;
            }
        }

        Console.WriteLine("Thanks for using our program!");
    }

}
