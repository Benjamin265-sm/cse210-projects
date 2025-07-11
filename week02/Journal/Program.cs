using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JournalApp
{
    class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string Date { get; set; }

        public Entry(string prompt, string response, string date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }

        public void Display()
        {
            Console.WriteLine($"Date: {Date} - Prompt: {Prompt}");
            Console.WriteLine($"Response: {Response}");
        }
    }

    class Journal
    {
        public List<Entry> Entries { get; set; }

        public Journal()
        {
            Entries = new List<Entry>();
        }

        public void AddEntry(Entry newEntry)
        {
            Entries.Add(newEntry);
        }

        public void DisplayAllEntries()
        {
            foreach (var entry in Entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        private static Journal journal = new Journal();
        private static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing I learned today?",
        "What challenge did I overcome today?"
    };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Journal Program!");

            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            WriteJournalEntry();
                            break;
                        case 2:
                            DisplayJournal();
                            break;
                        case 3:
                            LoadJournalFromFile();
                            break;
                        case 4:
                            SaveJournalToFile();
                            break;
                        case 5:
                            Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                Console.WriteLine(); // Add a blank line for better readability
            }
        }

        static void WriteJournalEntry()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            string randomPrompt = prompts[index];

            Console.WriteLine($"Prompt: {randomPrompt}");
            Console.Write("Your response: ");
            string response = Console.ReadLine();

            string date = DateTime.Now.ToShortDateString();

            Entry newEntry = new Entry(randomPrompt, response, date);
            journal.AddEntry(newEntry);
            Console.WriteLine("Entry saved successfully!");
        }

        static void DisplayJournal()
        {
            if (journal.Entries.Any())
            {
                Console.WriteLine("\n--- Journal Entries ---");
                journal.DisplayAllEntries();
                Console.WriteLine("--- End of Journal ---\n");
            }
            else
            {
                Console.WriteLine("Journal is empty. Write an entry first.");
            }
        }

        static void LoadJournalFromFile()
        {
            Console.Write("Enter filename to load from: ");
            string filename = Console.ReadLine();

            if (File.Exists(filename))
            {
                journal.Entries.Clear(); // Clear current entries
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");
                    if (parts.Length == 3)
                    {
                        string date = parts[0];
                        string prompt = parts[1];
                        string response = parts[2];
                        journal.AddEntry(new Entry(prompt, response, date));
                    }
                }
                Console.WriteLine("Journal loaded successfully!");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        static void SaveJournalToFile()
        {
            Console.Write("Enter filename to save to: ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (var entry in journal.Entries)
                {
                    outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }
    }
}

