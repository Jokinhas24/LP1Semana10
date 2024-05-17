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
    }
}