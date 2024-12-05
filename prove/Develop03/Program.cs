using System;

class Program
{
    static void Main()
    {
        // Example scripture: "For God so loved the world"
        string scriptureText = "For God so loved the world";
        Reference reference = new Reference("John", 3, 16);

        // Create a Scripture object
        Scripture scripture = new Scripture(scriptureText, reference);

        // Display initial scripture
        Console.WriteLine("Original scripture: ");
        Console.WriteLine(scripture.GetDisplayText());
        
        // Hide 2 random words
        scripture.HideRandomWords(2);
        
        // Display scripture after hiding some words
        Console.WriteLine("\nScripture after hiding words: ");
        Console.WriteLine(scripture.GetDisplayText());

        // Check if all words are hidden
        Console.WriteLine("\nIs the scripture completely hidden?");
        Console.WriteLine(scripture.IsCompletelyHidden());

        // End the program when all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nKeep memorizing! Scripture: ");
            Console.WriteLine(scripture.GetDisplayText());
            scripture.HideRandomWords(1); // Hide 1 word randomly
            Console.WriteLine("\nPress any key to hide more words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
        }

        Console.WriteLine("\nProgram Ended.");
    }
}
