using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<Player> playerlist = new List<Player>()
            {
                new Player("Jokinhas", 24),
                new Player("Bugs", 2),
                new Player("Cat", 500)
            };

            Controller controller = new Controller(playerlist);

            View view = new View(controller, playerlist);

            controller.Start(view);
        }
}
}