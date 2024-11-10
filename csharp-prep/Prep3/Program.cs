using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string keep_playing = "yes";

        while (keep_playing == "yes")
        {
            int magic_number = random.Next(1, 101);
            int guess_count = 0;
            int guess = -1;

            while (guess != magic_number)
            {
                Console.Write("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
                guess_count++;

                if (guess > magic_number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess < magic_number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {guess_count} guesses");

            Console.Write("Would you like to play again (yes/no)? ");
            keep_playing = Console.ReadLine();
        }

        Console.WriteLine("Thank you for playing. Goodbye.");
    }
}