public class ListingActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    public override void ExecuteActivity()
    {
        Console.Clear();
        StartActivity();

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Please list an item: ");
            string input = Console.ReadLine();
            count++;
            ShowSpinner(1); // Pause briefly
        }

        Console.WriteLine($"You listed {count} items!");
        EndActivity();
    }
}
