using System.Text;
Console.OutputEncoding = Encoding.UTF8;

string[,] game =
        {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" }
        };
int playerTurn = 0;
bool gameOver = false;

Console.WriteLine("Старт гри ");
for (int i = 0; i < game.GetLength(0); i++)
{
    for (int j = 0; j < game.GetLength(1); j++)
    {
        Console.Write($" {game[i, j]} |");
    }
    Console.WriteLine();
    Console.WriteLine("------------");
}
Console.WriteLine("Гравець 1, введіть свій нік");
Console.ForegroundColor = ConsoleColor.Cyan;
string firstPlayerName = Console.ReadLine();
Console.ResetColor();

Console.WriteLine("Гравець 2, введіть свій нік");
Console.ForegroundColor = ConsoleColor.DarkBlue;
string secondPlayerName = Console.ReadLine();
Console.ResetColor();

while (!gameOver)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"{firstPlayerName}, ваш хід");
    Console.ResetColor();

    Console.Write("Введіть номер (від 1 до 9): ");
    int input;
    try
    {
        input = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Введене не числове значення!");
        Console.ResetColor();

        continue;
    }
    if (input >= 1 && input <= 9)
    {
        int row = (input - 1) / 3;
        int col = (input - 1) % 3;
        if (row >= 0 && row < game.GetLength(0) && col >= 0 && col < game.GetLength(1) &&
        game[row, col] != "X" && game[row, col] != "0")
        {
            string firstPlayer = "X";

            game[row, col] = firstPlayer;
            int rows = game.GetLength(0);
            int cols = game.GetLength(1);
            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                {
                    Console.Write($" {game[i, j]} |");
                }
                Console.WriteLine();
                Console.WriteLine("------------");
            }
            for (int i = 0; i < 3; i++)
            {
                if (game[i, 0] == game[i, 1] && game[i, 1] == game[i, 2])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Гравець {firstPlayerName} виграв!!! ");
                    Console.ResetColor();
                    gameOver = true;
                    break;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (game[0, i] == game[1, i] && game[1, i] == game[2, i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Гравець {firstPlayerName} виграв!!! ");
                    Console.ResetColor();
                    gameOver = true;
                    break;
                }
            }
            if (game[0, 0] == game[1, 1] && game[1, 1] == game[2, 2] ||
                game[0, 2] == game[1, 1] && game[1, 1] == game[2, 0])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Гравець {firstPlayerName} виграв!!! ");
                Console.ResetColor();
                gameOver = true;
                break;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{firstPlayerName} місце вже зайняте!");
            Console.ResetColor();
            continue;
        }
        bool isDraw = true;
        for (int i = 0; i < game.GetLength(0); i++)
        {
            for (int j = 0; j < game.GetLength(1); j++)
            {
                if (game[i, j] != "X" && game[i, j] != "0")
                {
                    isDraw = false;
                    break;
                }
            }
        }
        if (isDraw)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Нічия! Ніхто не виграв!");
            Console.ResetColor();
            gameOver = true;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{firstPlayerName} вийшов за межі ігрового поля! ");
        Console.ResetColor();
        continue;
    }
    if (gameOver)
        break;

    bool checkMove = false;
    while (!checkMove)
    {
        playerTurn = (playerTurn + 1) % 2;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"{secondPlayerName}, ваш хід");
        Console.ResetColor();
        Console.Write("Введіть номер (від 1 до 9) ");
        try
        {
            input = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введене не числове значення!");
            Console.ResetColor();
            continue;
        }
        if (input >= 1 && input <= 9)
        {
            int row1 = (input - 1) / 3;
            int col1 = (input - 1) % 3;

            if (row1 >= 0 && row1 < game.GetLength(0) && col1 >= 0 && col1 < game.GetLength(1) &&
                game[row1, col1] != "X" && game[row1, col1] != "0")
            {
                string secondPlayer = "0";
                checkMove = true;
                game[row1, col1] = secondPlayer;
                for (int i = 0; i < game.GetLength(0); i++)
                {
                    for (int j = 0; j < game.GetLength(1); j++)
                    {
                        Console.Write($" {game[i, j]} |");
                    }
                    Console.WriteLine();
                    Console.WriteLine("------------");
                }
                for (int i = 0; i < 3; i++)
                {
                    if (game[i, 0] == game[i, 1] && game[i, 1] == game[i, 2])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Гравець {secondPlayerName} виграв ");
                        Console.ResetColor();
                        gameOver = true;
                        break;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    if (game[0, i] == game[1, i] && game[1, i] == game[2, i])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Гравець {secondPlayerName} виграв!!! ");
                        Console.ResetColor();
                        gameOver = true;
                        break;
                    }
                }
                if (game[0, 0] == game[1, 1] && game[1, 1] == game[2, 2] ||
                game[0, 2] == game[1, 1] && game[1, 1] == game[2, 0])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Гравець {secondPlayerName} виграв!!! ");
                    Console.ResetColor();
                    gameOver = true;
                    break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{secondPlayerName} місце вже зайняте!");
                Console.ResetColor();
                continue;
            }

            bool isDraw = true;
            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                {
                    if (game[i, j] != "X" && game[i, j] != "0")
                    {
                        isDraw = false;
                        break;
                    }
                }
            }
            if (isDraw)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Нічия! Ніхто не виграв!");
                Console.ResetColor();
                gameOver = true;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{secondPlayerName} вийшов за межі ігрового поля!");
            Console.ResetColor();
            continue;
        }
    }
}
