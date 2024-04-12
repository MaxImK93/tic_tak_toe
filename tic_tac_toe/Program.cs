using System;

namespace tic_tac_toe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Field startField = new Field();

            startField.DrawField();

            Sings turn = new Sings();

            int turns = 0; // Отслеживание количества сделанных ходов
            while (true)
            {
                turn.PlayerXTurn();
                turns++;
                if (turn.CheckForWinner())
                {
                    Console.WriteLine("X победил!");
                    break;
                }
                if (turns == 9)
                {
                    Console.WriteLine("Ничья!");
                    break;
                }

                turn.PlayerOTurn();
                turns++;
                if (turn.CheckForWinner())
                {
                    Console.WriteLine("O победил!");
                    break;
                }
                if (turns == 9)
                {
                    Console.WriteLine("Ничья!");
                    break;
                }
            }

        }
    }
}
