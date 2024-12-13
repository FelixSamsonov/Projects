using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        DateTime time = DateTime.Now;
        StringBuilder text = new StringBuilder($"Запис створено: {time:dd.MM.yyyy HH:mm:ss}\n");
        string input;

        while (true)
        {
            input = GetInput("Введіть прізвище та ім'я (або 'end'/ 'утв' для завершення):");
            if (Check(input)) break;
            text.Append($"Звіт створив: {input}\n");

            string topic = GetInput("Введіть заголовок вашого звіту (або 'end'/'утв' для завершення):");
            if (Check(topic)) break;
            text.Append($"Тема звіту: {topic}\n");

            Console.WriteLine("Введіть текст звіту (по завершенню введіть 'end'/'утв'):");
            while (true)
            {
                string report = Console.ReadLine();
                if (Check(report)) break;
                text.AppendLine(report);
            }

            Console.WriteLine("Дані звіту збережено. Ви можете продовжити або завершити програму ('end'/'утв').");
        }
        Console.WriteLine("\nВведені дані:");
        Console.WriteLine(text.ToString());
    }

    static string GetInput(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }

    static bool Check(string input)
    {
        return input?.ToLower() == "end" || input?.ToLower() == "утв";// "утв" для того, якщо текст вводився українською
                                                                      // або російською,
                                                                      // щоб не приходилося переключатися на англ.
    }
}
