using System;

class Program
{
    static void Main(string[] args)
    {
        int userOption = 0 ;
        
        while (userOption != 4) {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice of the menu: ");
            string userOptions = Console.ReadLine();
            
            if (userOptions == "1") {
                BreathingActivity breathingActivity = new BreathingActivity("", "", 0);
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }

            if (userOptions == "2") {
                ReflectingActivity reflectingActivity = new ReflectingActivity("", "", 0);
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }

            if (userOptions == "3") {
                ListingActivity listingActivity = new ListingActivity("", "", 0);
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }
            if (userOptions == "4") {
                userOption = 4;
            }
        }

        Console.WriteLine("Thanks for using our program!");
    }
    
}




    

            // BreathingActivity breathingActivity = new BreathingActivity("", "", int.Parse(seconds));
            // breathingActivity.DisplayStartingMessage();
            // breathingActivity.Run();
            // breathingActivity.DisplayEndingMessage();

            // ListingActivity listingActivity = new ListingActivity("", "", int.Parse(seconds));
            // listingActivity.DisplayStartingMessage();
            // listingActivity.Run();
            // listingActivity.DisplayEndingMessage();


            // ReflectingActivity reflectingActivity = new ReflectingActivity("", "", int.Parse(seconds));
            // reflectingActivity.DisplayStartingMessage();
            // reflectingActivity.Run();
            // reflectingActivity.DisplayEndingMessage();
            // Activity activity = new Activity("Breathing", "eoisnoisef", int.Parse(seconds));
            // activity.DisplayStartingMessage();
            // activity.DisplayEndingMessage();




            // Console.WriteLine(string.Join(",", animationStages));

            // foreach (string s in animationStages){
            //     Console.Write(s);
            //     Thread.Sleep(1000);
            //     Console.Write("\b \b");
            // }