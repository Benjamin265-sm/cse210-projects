public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordGoal(int index)
    {
        if (index < 0 || index >= goals.Count) return;
        totalScore += goals[index].RecordEvent();
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Total Score: {totalScore}");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {goals[i].GetStatus()}");
        }
    }

    public void Save(string filename)
    {
        var json = System.Text.Json.JsonSerializer.Serialize(this);
        File.WriteAllText(filename, json);
    }

    public static GoalManager Load(string filename)
    {
        if (!File.Exists(filename)) return new GoalManager();
        var json = File.ReadAllText(filename);
        return System.Text.Json.JsonSerializer.Deserialize<GoalManager>(json);
    }
}
