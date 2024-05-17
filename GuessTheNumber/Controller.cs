using System;

namespace GuessTheNumber
{
    public class Controller
    {
        private bool guessedCorrectly = false;

        Start(view)
        {
            view.Welcome()

            int guess;

            // Game loop
            while (!guessedCorrectly)
            {
                Console.Write("Take a guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                model.attempts++;

                if (guess == targetNumber)
                {
                    view.Win();
                    guessedCorrectly = true;
                }
                else if (guess < targetNumber)
                {
                    view.Low();
                }
                else
                {
                    view.High();
                }
            }
        }
    }
}