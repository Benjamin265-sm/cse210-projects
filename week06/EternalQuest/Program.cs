using System;

class Program
{
    static void Main()
    {
        string filename = "goals.dat";
        var manager = GoalManager.Load(filename);

        while (true)
        {
            Console.Clear();
            manager.DisplayStatus();
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Simple Goal");
            Console.WriteLine("2. Add Eternal Goal");
            Console.WriteLine("3. Add Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save & Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Title: ");
                var title = Console.ReadLine();
                Console.Write("Points: ");
                var points = int.Parse(Console.ReadLine());
                manager.AddGoal(new SimpleGoal(title, points));
            }
            else if (choice == "2")
            {
                Console.Write("Title: ");
                var title = Console.ReadLine();
                Console.Write("Points each time: ");
                var points = int.Parse(Console.ReadLine());
                manager.AddGoal(new EternalGoal(title, points));
            }
            else if (choice == "3")
            {
                Console.Write("Title: ");
                var title = Console.ReadLine();
                Console.Write("Points each time: ");
                var points = int.Parse(Console.ReadLine());
                Console.Write("Times required: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus at completion: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(title, points, target, bonus));
            }
            else if (choice == "4")
            {
                manager.DisplayStatus();
                Console.Write("Goal number to record: ");
                int num = int.Parse(Console.ReadLine()) - 1;
                manager.RecordGoal(num);
            }
            else if (choice == "5")
            {
                manager.Save(filename);
                break;
            }
        }
    }
}