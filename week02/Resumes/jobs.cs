using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"Job Title: {_jobTitle}, Company: {_company}, Start Year: {_startYear}, End Year: {_endYear}");
    }
}