public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through deep breathing exercises. Focus on your breath and clear your mind.")
    { }

    public override void ExecuteActivity()
    {
        Console.Clear();
        StartActivity();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3); // Pause with spinner
            Console.WriteLine("Breathe out...");
            ShowSpinner(3); // Pause with spinner
        }

        EndActivity();
    }
}
