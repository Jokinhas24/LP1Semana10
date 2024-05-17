using System;

namespace GuessTheNumber
{
    public class Model
    {
        public int targetNumber{get;}

        public int attempts{ get; set;}

        Random random = new Random();

        public Model()
        {
            targetNumber = random.Next(1, 101);
            attempts = 0;
        }
    }
}