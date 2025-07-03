using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 100);
        // Console.Write("what is the magic number? ");
        // string input = Console.ReadLine();
        // int magicNumber = int.Parse(input);

        int guess = 0;
        int guesses = 0;
        while (guess != magicNumber)
        {
            Console.Write("what is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            guesses++;

            if (guess == magicNumber)
            {
                Console.WriteLine("you guessed the magic number!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }




        }
        Console.WriteLine($"You guessed {guesses} times.");
        
        

       
    }
}