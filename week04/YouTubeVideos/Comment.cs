using System;


// Represents a single comment on a video
public class Comment
{
    private string author;
    private string text;

    public Comment(string author, string text)
    {
        this.author = author;
        this.text = text;
    }

    // Returns a formatted string for display
    public string GetDisplayText()
    {
        return $"{author}: {text}";
    }
}