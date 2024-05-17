using system;

namespace PlayerManagerMVC
{
    interface IView
    {
        void ShowMenu();

        void EndMessage();
        
        void InvalidOption();

        void AfterMenu();

        void InsertPlayer();

        void ListPlayers();

        void AskforPlayerOrder();
    }
}