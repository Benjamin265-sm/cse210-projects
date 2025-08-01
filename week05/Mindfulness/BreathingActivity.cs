
class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        name = "Breathing Activity";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;
        while (elapsed < durationSeconds)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            elapsed += 4;

            if (elapsed >= durationSeconds) break;

            Console.Write("Breathe out...");
            ShowCountDown(6);
            elapsed += 6;
        }

        DisplayEndingMessage();
    }
}
