using system;

namespace PlayerManagerMVC
{
    public class View : IView
    {
        void void ShowMenu()
        {

        }

        public void EndMessage()
        {
            Console.WriteLine("Bye!")
        }

        public InvalidOption()
        {
            Console.WriteLine("\n >>>Unknown Option!<<<")
        }

        public AfterMenu()
        {
            Console.Write("\nPress any key to continue...");
                Console.ReadKey(true);
                Console.WriteLine("\n");
        }   
    }
}
