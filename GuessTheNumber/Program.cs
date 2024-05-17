﻿using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            Controller controller = new Controller(model);

            View view = new View(controller, model);

            controller.Start(view);

            // Generate a random number
            Random random = new Random();

            // Generate a number between 1 and 100
            int targetNumber = random.Next(1, 101);

            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");

            // Game loop
            while (!guessedCorrectly)
            {
                Console.Write("Take a guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess == targetNumber)
                {
                    Console.WriteLine(
                        "Congratulations! You guessed the number correctly!");
                    Console.WriteLine("Number of attempts: " + attempts);
                    guessedCorrectly = true;
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }

            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}