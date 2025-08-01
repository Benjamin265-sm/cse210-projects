using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    protected string name;
    protected string description;
    protected int durationSeconds;

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {name} ---\n");
        Console.WriteLine(description);
        Console.Write("\nEnter duration (seconds): ");
        durationSeconds = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed the {name} for {durationSeconds} seconds.");
        ShowSpinner(2);
    }

    protected void ShowSpinner(int seconds)
    {
        var spinner = new[] { "|", "/", "-", "\\" };
        var start = DateTime.Now;
        int i = 0;
        while ((DateTime.Now - start).TotalSeconds < seconds)
        {
            Console.Write(spinner[i++ % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public abstract void Run();
}