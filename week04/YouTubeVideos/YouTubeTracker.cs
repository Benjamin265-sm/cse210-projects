using System;

public class YouTubeTracker
{
    private List<Video> videos = new List<Video>();

    public void AddVideo(Video v)
    {
        videos.Add(v);
    }

    public void DisplayAll()
    {
        foreach (var v in videos)
        {
            Console.WriteLine(v.GetSummary());
            Console.WriteLine("Comments:");
            foreach (var c in v.GetComments())
            {
                Console.WriteLine($"  • {c.GetDisplayText()}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}