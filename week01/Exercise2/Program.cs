using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = grade.ToUpper();
        if (number >= 90)
        {

            letter = "A";
        }
        else if (number >= 80)
        {

            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (number >= 70)
        {
            Console.WriteLine("You have passed the course.");
        }
        else
        {
            Console.WriteLine("You have failed the course, try again next time.");
        }
        Console.WriteLine($"Your grade is {letter}.");

    }
}