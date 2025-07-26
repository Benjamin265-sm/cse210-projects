using System;

class Program
{
    static void Main(string[] args)
    {
        var tracker = new YouTubeTracker();

        // Create Video objects and add comments
        var vid1 = new Video("C# Basics", "Alice", 600);
        vid1.AddComment(new Comment("Bob", "Great intro!"));
        vid1.AddComment(new Comment("Carol", "Very helpful."));
        vid1.AddComment(new Comment("Dave", "Needs more examples."));
        tracker.AddVideo(vid1);

        var vid2 = new Video("LINQ in Action", "Eve", 900);
        vid2.AddComment(new Comment("Frank", "Awesome explanation."));
        vid2.AddComment(new Comment("Grace", "Nice and concise."));
        vid2.AddComment(new Comment("Heidi", "Loved the demos."));
        tracker.AddVideo(vid2);

        var vid3 = new Video("Async/Await Deep Dive", "Ivan", 1200);
        vid3.AddComment(new Comment("Judy", "Excellent coverage."));
        vid3.AddComment(new Comment("Ken", "A bit advanced but clear."));
        vid3.AddComment(new Comment("Leo", "Thanks for this!"));
        tracker.AddVideo(vid3);

        // Display everything
        tracker.DisplayAll();
    }
}