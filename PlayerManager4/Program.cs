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
                new Player("Bugs", 2)
                new Player("Cat", 500)
            }

            // Initialize player comparers
            compareByName = new CompareByName(true);
            compareByNameReverse = new CompareByName(false);

            Program prog = new Program();

            controller controller = new controller()
            View view = new view(controller)
            
            controller.Start();
        }
}
}