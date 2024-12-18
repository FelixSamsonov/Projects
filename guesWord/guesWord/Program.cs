using System;
using System.Text;

namespace guesWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            StartScreen();

            string inputNumber = Console.ReadLine();
            Console.WriteLine();
            string word = ListOfWord(inputNumber);
            char[] charWord1 = word.ToArray();
            char[] guessedWord = new string('_', charWord1.Length).ToCharArray();
            int remainingAttempts = charWord1.Length;

            InfoScreen(remainingAttempts);

            bool isWordGuessed = false;

            while (remainingAttempts > 0 && !isWordGuessed)
            {
                Console.WriteLine($"Ваше слово: {new string(guessedWord)}");
                Console.Write("Введіть вашу букву:");
                char searchChar = char.ToLower(Console.ReadLine()[0]);

                bool isCharFound = false;

                for (int i = 0; i < charWord1.Length; i++)
                {
                    if (charWord1[i] == searchChar)
                    {
                        guessedWord[i] = searchChar;
                        isCharFound = true;
                    }
                }

                if (isCharFound)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Буква '{searchChar}' присутня!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    remainingAttempts--;
                    Console.WriteLine($"Буква '{searchChar}' не знайдено. У вас залишилось {remainingAttempts} спроб.");
                    Console.ResetColor();
                }

                isWordGuessed = !guessedWord.Contains('_');

                if (isWordGuessed)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Вітаємо! Ви відгадали слово: {new string(guessedWord)}");
                    Console.ResetColor();
                }
                else if (remainingAttempts == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("У вас залишилось 0 спроб. Ви програли.");
                    Console.WriteLine($"Зашифроване слово було: {word}");
                    Console.ResetColor();
                }
            }
        }
        static string ListOfWord(string numb)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            switch (numb)
            {

                case "1":
                    Console.WriteLine("Найшвидша тварина у світі?");
                    return "гепард";
                case "2":
                    Console.WriteLine("Найвища гора у світі?");
                    return "еверест";
                case "3":
                    Console.WriteLine("Плід, який називають 'королем фруктів'?");
                    return "манго";
                case "4":
                    Console.WriteLine("Місто, яке називають 'містом світла'?");
                    return "париж";
                case "5":
                    Console.WriteLine("Країна, яка має найбільше населення у світі?");
                    return "китай";
                case "6":
                    Console.WriteLine("Яка річка переносить найбільшу кількість прісної води у світі (~20% світового об’єму)?");
                    return "амазонка";
                case "7":
                    Console.WriteLine("Найвищий водоспад у світі?");
                    return "анхель";
                case "8":
                    Console.WriteLine("Найменша країна в світі?");
                    return "ватикан";
                case "9":
                    Console.WriteLine("Музичний інструмент з клавішами і струнами?");
                    return "рояль";
                case "10":
                    Console.WriteLine("Місто, яке називають 'вітряним'?");
                    return "чикаго";
                default:
                    throw new Exception("Введено не число, або введене число не входить в діапазон від 1 до 10");


            }
        }
        static void StartScreen()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Вітаємо! Спробуйте відгадати слово!");
            Console.WriteLine("Для вибору завдання введіть число від 1 до 10");
            Console.ResetColor();
        }
        static void InfoScreen(int remainingAttempts)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Кількість літер у слові: {remainingAttempts}");
            Console.WriteLine($"Кількість можливих невірних спроб: {remainingAttempts}");
            Console.ResetColor();
        }
    }
}
