using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 100);
        // Console.Write("what is the magic number? ");
        // string input = Console.ReadLine();
        // int magicNumber = int.Parse(input);

        int guess = 0;
        while (guess != randomNumber)
        {
            Console.Write("what is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess == randomNumber)
            {
                Console.WriteLine("you guessed the magic number!");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        
        

       
    }
}