using System;

namespace GuessTheNumber
{
    public class View : IView
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public void void Win()
        {
            Console.WriteLine(
                        "Congratulations! You guessed the number correctly!");
                    Console.WriteLine("Number of attempts: " + model.attempts);
        }

        public void Low()
        {
            Console.WriteLine("Too low! Try again.");
        }

        public void High()
        {
            Console.WriteLine("Too high! Try again.");
        }
        public void End()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}