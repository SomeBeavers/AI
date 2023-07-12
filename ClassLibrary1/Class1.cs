using System;
using Newtonsoft.Json;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = $"Count is\t: {this.Is.A.Really(long(expr))
                .That.I.Should(
                    be + able)[
                    to.Wrap()]}.";

            JsonConvert.SerializeObject(new { });
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int attempts = 0;
            int userGuess;
            bool isCorrect = false;
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            while (!isCorrect)
            {
                Console.Write("Enter your guess: ");
                userGuess = int.Parse(Console.ReadLine());
                attempts++;
                if (userGuess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the correct number {secretNumber} in {attempts} attempts.");
                    isCorrect = true;
                }
            }
        }
    }
}