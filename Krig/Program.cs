using System;

namespace Krig
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalTurnCount = 0;
            int finiteGameCount = 0;
            for (int i = 0; i < 10000; i++)
            {
                //Create game
                Game game = new Game("Alice", "Bob");
                while (!game.IsEndOfGame())
                {
                    game.PlayTurn();
                }

                if (game.TurnCount < 1000)
                {
                    totalTurnCount += game.TurnCount;
                    finiteGameCount++;
                }
                Console.Read();
            }
            Console.Read();

        }
    }
}
