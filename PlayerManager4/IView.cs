using system;

namespace PlayerManagerMVC
{
    interface IView
    {
        void ShowMenu();

        void EndMessage();
        
        void InvalidOption();

        void AfterMenu();
    }
}