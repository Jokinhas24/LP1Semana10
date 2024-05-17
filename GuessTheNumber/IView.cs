using System;

namespace GuessTheNumber
{
    public interface IView
    {
        void Welcome();

        int Guess();

        void Win();

        void Low();

        void High();

        void End();
    }
}