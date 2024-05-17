using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public interface IView
    {
        int ShowMenu();

        void EndMessage();
        
        void InvalidOption();

        void AfterMenu();

        Player InsertPlayer();

        void ListPlayers(IEnumerable<Player> playersToList);

        PlayerOrder AskforPlayerOrder();

        int AskForMinScore();
    }
}