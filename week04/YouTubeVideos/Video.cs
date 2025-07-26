using System;

public class Video
{
    private string title;
    private string author;
    private int lengthSeconds;
    private List<Comment> comments;

    public Video(string title, string author, int lengthSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthSeconds = lengthSeconds;
        this.comments = new List<Comment>();
    }

    public void AddComment(Comment c)
    {
        comments.Add(c);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public IEnumerable<Comment> GetComments()
    {
        return comments;
    }

    public string GetSummary()
    {
        return $"Title: {title}\nAuthor: {author}\nLength: {lengthSeconds} seconds\nComments: {GetCommentCount()}";
    }
}