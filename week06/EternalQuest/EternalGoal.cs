public class EternalGoal : Goal
{
    public EternalGoal(string title, int points) : base(title, points) { }

    public override int RecordEvent()
    {
        return points;
    }
}
