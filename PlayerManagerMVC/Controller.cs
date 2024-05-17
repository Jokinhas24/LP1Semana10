using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    /// <summary>
    /// The player listing program.
    /// </summary>
    public class Controller
    {
        // Comparer for comparing player by name (alphabetical order)
        private readonly IComparer<Player> compareByName;

        // Comparer for comparing player by name (reverse alphabetical order)
        private readonly IComparer<Player> compareByNameReverse;

        private List<Player> model;

        private IView view;

        public Controller(List<Player> model)
        {
            this.model = model;
            compareByName = new CompareByName(true);
            compareByNameReverse = new CompareByName(false);
        }
        /// <summary>
        /// Start the player listing program instance
        /// </summary>
        public void Start(IView newView)
        {
            view = newView;

            // We keep the user's option here
            int option;

            // Main program loop
            do
            {
                // Show menu and get user option
                option = view.ShowMenu();

                // Determine the option specified by the user and act on it
                switch (option)
                {
                    case 1:
                        // Insert player
                        model.Add(view.InsertPlayer());
                        break;
                    case 2:
                        view.ListPlayers(model);
                        break;
                    case 3:
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case 4:
                        Sortmodel();
                        break;
                    case 0:
                        view.EndMessage();
                        break;
                    default:
                        view.InvalidOption();
                        break;
                }
                view.AfterMenu();

                // Loop keeps going until players choses to quit (option 4)
            } while (option != 0);
        }

        /// <summary>
        /// Show all players with a score higher than a user-specified value.
        /// </summary>
        private void ListPlayersWithScoreGreaterThan()
        {
            // Enumerable of players with score higher than the minimum score
            IEnumerable<Player> playersWithScoreGreaterThan;

            // Get players with score higher than the user-specified value
            playersWithScoreGreaterThan =
                GetPlayersWithScoreGreaterThan(view.AskForMinScore());

            // List all players with score higher than the user-specified value
            view.ListPlayers(playersWithScoreGreaterThan);
        }

        private void Sortmodel()
        {
            PlayerOrder playerOrder = view.AskforPlayerOrder();

            switch (playerOrder)
            {
                case PlayerOrder.ByScore:
                    model.Sort();
                    break;
                case PlayerOrder.ByName:
                    model.Sort(compareByName);
                    break;
                case PlayerOrder.ByNameReverse:
                    model.Sort(compareByNameReverse);
                    break;
                default:
                    view.InvalidOption();
                    break;
            }
        }

        /// <summary>
        /// Get players with a score higher than a given value.
        /// </summary>
        /// <param name="minScore">Minimum score players should have.</param>
        /// <returns>
        /// An enumerable of players with a score higher than the given value.
        /// </returns>
        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            // Cycle all players in the original player list
            foreach (Player p in model)
            {
                // If the current player has a score higher than the
                // given value....
                if (p.Score > minScore)
                {
                    // ...return him as a member of the player enumerable
                    yield return p;
                }
            }
        }
    }
}
