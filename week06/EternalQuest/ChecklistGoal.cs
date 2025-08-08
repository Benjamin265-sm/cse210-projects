public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount = 0;
    private int bonus;

    public ChecklistGoal(string title, int points, int targetCount, int bonus) : base(title, points)
    {
        this.targetCount = targetCount;
        this.bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (currentCount >= targetCount) return 0;
        currentCount++;
        if (currentCount == targetCount)
        {
            return points + bonus;
        }
        return points;
    }

    public override string GetStatus()
    {
        return $"[ ] {title} — Completed: {currentCount}/{targetCount}";
    }
}