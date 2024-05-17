using System;

namespace GuessTheNumber
{
    public class Controller
    {
        public Model model;

        public IView view;

        private bool guessedCorrectly = false;

        public Controller(Model model)
        {
            this.model = model;
        }

        public void Start(IView view)
        {
            this.view = view;

            view.Welcome();

            int guess;

            // Game loop
            while (!guessedCorrectly)
            {
                guess = view.Guess();
                model.attempts++;

                if (guess == model.targetNumber)
                {
                    view.Win();
                    guessedCorrectly = true;
                }
                else if (guess < model.targetNumber)
                {
                    view.Low();
                }
                else
                {
                    view.High();
                }
            }

            view.End();
        }
    }
}