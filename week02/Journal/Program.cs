using System;
using System.IO; 
/*I have added the hour to each response to the prompt*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Hello World! This is the Journal Project.");
        int inputNumber = -1;

        try 
        {
            Journal theJournal = new Journal();
            do 
            {
                Console.WriteLine("");
                Console.WriteLine("Please select one of the following choices: ");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What will you choose? ");
                string userResponse = Console.ReadLine();
                inputNumber = int.Parse(userResponse);

                //This part of code is to Build the options 

                //Write Option
                if (inputNumber == 1){

                    PromptGenerator prompt = new PromptGenerator(); // To call the PromptGenerator function
                    prompt._prompts.Add("What was the best part of your day?");
                    prompt._prompts.Add("What challenges did you face today?");
                    prompt._prompts.Add("What are you grateful for today?");
                    prompt._prompts.Add("Describe a moment that made you smile.");
                    prompt._prompts.Add("What lessons did you learn today?");
                    prompt._prompts.Add("If you could relive today, what would you do differently?");
                    prompt._prompts.Add("What emotions did you experience today?");
                    prompt._prompts.Add("What are your goals for tomorrow?");
                    prompt._prompts.Add("Write about a person who impacted your day.");
                    prompt._prompts.Add("What song or movie best represents your mood today?");
                    prompt._prompts.Add("What is something new you learned today?");
                    prompt._prompts.Add("What was the most surprising thing that happened?");
                    prompt._prompts.Add("Write about a dream you had recently.");
                    prompt._prompts.Add("What is one thing you wish you could change?");
                    prompt._prompts.Add("How did you take care of yourself today?");
                    prompt._prompts.Add("Describe a place you visited today and how it felt.");
                    prompt._prompts.Add("What is a small victory you achieved today?");
                    prompt._prompts.Add("What is something you are looking forward to?");
                    prompt._prompts.Add("If today had a theme, what would it be?");
                    prompt._prompts.Add("Write a letter to your future self.");
                    
                    
                    string randomPrompt = prompt.GetRandomPrompt(); 
                    Console.WriteLine(randomPrompt);
                    Console.Write("");
                    string entryText = Console.ReadLine();

                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    string hourText = theCurrentTime.ToShortTimeString();


                    Entry theEntry = new Entry();
                    theEntry._date = dateText;
                    theEntry._prompText = randomPrompt;
                    theEntry._entryText = entryText;
                    theEntry._hour = hourText;

                    
                    theJournal.AddEntry(theEntry);
                }

                //Display Option
                if (inputNumber == 2){
                    theJournal.DisplayAll();
                }

                //Load Option
                if (inputNumber == 3){
                    Console.WriteLine("What is the filename? ");
                    Console.Write("");
                    string fileName = Console.ReadLine();
                    theJournal.LoadFromFile(fileName);
                }
                
                //Save Option
                if (inputNumber == 4){
                    Console.WriteLine("What is the filename? ");
                    Console.Write("");
                    string fileName = Console.ReadLine();
                    theJournal.SaveToFile(fileName);
                }

                //This following code is for the design of the program in the terminal
                if (inputNumber > 5 || inputNumber < 1) {
                    Console.WriteLine("The number you choose is not an option!");
                    Console.WriteLine("");
                }
                if (inputNumber == 5){
                    Console.WriteLine("Thanks for using our program! ");
                    Console.WriteLine("");
                }
                
            } while (inputNumber != 5);
        } 
        catch(Exception)
        {
            Console.WriteLine("");
            Console.WriteLine("You didn't write a number! Reset the program :)");
            Console.WriteLine("");
        }
    }
}