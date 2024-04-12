using System;
namespace tic_tac_toe
{
    public class Sings
    {

        int[] board = new int[9];
        int number = 0;
        int x0;
        int y0;
        
        public Sings()
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = 0; // Инициализация всех клеток как пустых (0)
            }
        }

        public void PlayerXTurn()
        {
            GetInputAndCalculateCoordinates();  // Получаем ввод и координаты
            board[number - 1] = 1;

            DrawSymbol('X', x0, y0);
 
        }

        public void PlayerOTurn()
        {
            GetInputAndCalculateCoordinates();  // Получаем ввод и координаты
            board[number - 1] = 2;

            DrawSymbol('O', x0, y0);
        
        }

        public void DrawSymbol(char symbol, int x0, int y0)
        {
            switch (symbol)
            {
                case 'X':
                    // Рисуем X
                    for (int x = x0; x < x0 + 4; x++)
                    {
                        for (int y = y0; y < y0 + 4; y++)
                        {
                            if (x == x0 || x == x0 + 3 || y == y0 || y == y0 + 3)
                            {
                                Console.SetCursorPosition(x, y);
                                Console.Write("*");
                            }
                        }
                    }
                    break;

                case 'O':
                    // Рисуем O
                    for (int x = x0; x < x0 + 4; x++)
                    {
                        for (int y = y0; y < y0 + 4; y++)
                        {
                            if (x - y == x0 - y0 || x + y == x0 + y0 + 3)
                            {
                                Console.SetCursorPosition(x, y);
                                Console.Write("*");
                            }
                        }
                    }
                    break;
            }
        }

        public void GetInputAndCalculateCoordinates()
        {
            char input;
            do
            {
                var keyInfo = Console.ReadKey(true);
                input = keyInfo.KeyChar;
                if (char.IsDigit(input) && input >= '1' && input <= '9' && board[input - '1'] == 0)
                {
                    // Если клетка свободна, выходим из цикла
                    break;
                }
            } while (true);

            number = input - '0';
            x0 = ((number - 1) % 3) * 5 + 1;
            y0 = ((number - 1) / 3) * 5 + 1;
        }

        public bool CheckForWinner()
        {
            // Проверка горизонталей
            for (int row = 0; row < 3; row++)
            {
                if (board[row * 3] != 0 &&
                    board[row * 3] == board[row * 3 + 1] &&
                    board[row * 3] == board[row * 3 + 2])
                {

                    return true;
                }
            }

            // Проверка вертикалей
            for (int col = 0; col < 3; col++)
            {
                if (board[col] != 0 &&
                    board[col] == board[col + 3] &&
                    board[col] == board[col + 6])
                {
                    return true;
                }
            }

            // Проверка диагоналей
            if (board[0] != 0 && board[0] == board[4] && board[0] == board[8])
            {
                return true;
            }
            if (board[2] != 0 && board[2] == board[4] && board[2] == board[6])
            {
                return true;
            }

            return false;
        }

    }
}
