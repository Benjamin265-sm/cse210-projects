public class SimpleGoal : Goal
{
    private bool isComplete = false;

    public SimpleGoal(string title, int points) : base(title, points) { }

    public override int RecordEvent()
    {
        if (isComplete) return 0;
        isComplete = true;
        return points;
    }

    public override string GetStatus()
    {
        return $"{(isComplete ? "[X]" : "[ ]")} {title}";
    }
}
