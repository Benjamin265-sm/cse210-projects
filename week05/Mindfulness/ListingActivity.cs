class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Run()
    {
        DisplayStartingMessage();

        var rand = new Random();
        Console.WriteLine("\nPrompt:");
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine("\nStart listing (press Enter after each item):");
        var entries = new List<string>();
        var startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < durationSeconds)
        {
            Console.Write("> ");
            var item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                entries.Add(item);
        }

        Console.WriteLine($"\nYou listed {entries.Count} items.");
        DisplayEndingMessage();
    }
}