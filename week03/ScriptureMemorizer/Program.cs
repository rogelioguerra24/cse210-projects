using System;
/*I have added prompts to the user to think about the scripture to memorize that is a new class*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        string input = "";
        Reference reference = new Reference("Proverbs", 1, 5, 6);
        Scripture scripture = new Scripture(reference, "let the wise listen and add to their learning, and let the discerning get guidance for understanding proverbs and parables, the sayings and riddles of the wise"); 
        
        PromptGenerator prompt = new PromptGenerator(); // To call the PromptGenerator function
        prompt._prompts.Add("Can you recite the scripture without looking?");  
        prompt._prompts.Add("What is the first word of this scripture?");  
        prompt._prompts.Add("What comes after 'let the wise listen...' in this verse?");  
        prompt._prompts.Add("Fill in the blank: 'The sayings and ______ of the wise.'");  
        prompt._prompts.Add("Try writing the scripture down from memory, then check for mistakes.");

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.Write("Press Enter to continue or type 'quit' to finish: ");
        input = Console.ReadLine();
        if (input != "quit"){
            
        while (scripture.IsCompletelyHidden() == false) 
        {
            scripture.HideRandomWords(3); 
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            string randomPrompt = prompt.GetRandomPrompt(); 
            Console.WriteLine($"Hint: {randomPrompt}");
            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            
            input = Console.ReadLine(); // Read input inside the loop
            if (input.ToLower() == "quit"){
                break; 
            }
             
        };
        } else {
            return;
        }
    }  
}
// ?.Trim() Read input and remove spaces
// int.TryParse(input, out iniciate) Try to parse user input