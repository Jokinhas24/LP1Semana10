using system;

namespace PlayerManagerMVC
{
    class View : IView
    {
        private void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("4. Sort players");
            Console.WriteLine("0. Quit\n");
            Console.Write("Your choice > ");
        }

        private void EndMessage()
        {
            Console.WriteLine("Bye!")
        }

        private void InvalidOption()
        {
            Console.WriteLine("\n >>>Unknown Option!<<<")
        }

        private void AfterMenu()
        {
            Console.Write("\nPress any key to continue...");
                Console.ReadKey(true);
                Console.WriteLine("\n");
        }

        private void InsertPlayer()
        {
            string name;
            int score;
            Player newPlayer;

            Console.WriteLine("\nInsert player");
            Console.WriteLine("-------------\n");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());

            newPlayer = new Player(name, score);
            playerList.Add(newPlayer);
        }

        public static void ListPlayers(IEnumerable<Player> playersToList)
        {
            Console.WriteLine("\nList of players");
            Console.WriteLine("-------------\n");

            foreach (Player p in playersToList)
            {
                Console.WriteLine($" -> {p.Name} with a score of {p.Score}");
            }
            Console.WriteLine();
        }

        public 
    }
}
