using System;
namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int attempts = 0;
            bool isCorrect = false;
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            while (!isCorrect)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int guess))
                {
                    attempts++;
                    if (guess < secretNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                        isCorrect = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                }
            }
        }
    }
}