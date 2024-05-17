using System;

namespace GuessTheNumber
{
    public interface IView;
    {
        void Welcome();

        void Guess();

        void Win();

        void Low();

        void High();
    }
}