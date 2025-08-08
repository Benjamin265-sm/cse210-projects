using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public abstract class Goal
{
    protected string title;
    protected int points;

    public Goal(string title, int points)
    {
        this.title = title;
        this.points = points;
    }

    public abstract int RecordEvent(); 

    public virtual string GetStatus()
    {
        return $"[ ] {title}";
    }
}
