class ReflectingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
    {
        name = "Reflecting Activity";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    public override void Run()
    {
        DisplayStartingMessage();

        var rand = new Random();
        Console.WriteLine("\nPrompt:");
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        ShowSpinner(3);

        int elapsed = 3;
        while (elapsed < durationSeconds)
        {
            Console.WriteLine("\nQuestion:");
            Console.WriteLine(questions[rand.Next(questions.Count)]);
            ShowSpinner(5);
            elapsed += 5;
        }

        DisplayEndingMessage();
    }
}