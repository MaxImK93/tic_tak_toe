using System;
namespace tic_tac_toe
{
    public class Field
    {
        public Field()
        {
        }

        public void DrawField()
        {
            for (int y = 0; y <= 15; y += 5)
            {
                for (int x = 0; x <= 15; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("*");
                }
            }

            for (int x = 0; x <= 15; x += 5)
            {
                for (int y = 0; y <= 15; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("*");
                }
            }
        }
    }
}
