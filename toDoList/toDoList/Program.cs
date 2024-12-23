
using System.Text;

namespace toDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            StartedScreen();

            List<string> list = new List<string>();
            HashSet<int> completedIndices = new HashSet<int>(); 

            while (true)
            {
                ShowMenu();
                string actions = Console.ReadLine();

                switch (actions)
                {
                    case "1":
                        Console.WriteLine("Введіть, що додати до списку: ");
                        string inputAction = Console.ReadLine();
                        list.Add(inputAction);
                        Console.WriteLine($"Справу '{inputAction}' додано!");
                        break;

                    case "2":
                        Console.WriteLine("Введіть порядковий номер справи (починаючи з нуля), яку виконали:");
                        string inputDoneAction = Console.ReadLine();
                        if (int.TryParse(inputDoneAction, out int indexDone))
                        {
                            if (indexDone >= 0 && indexDone < list.Count)
                            {
                                completedIndices.Add(indexDone); 
                                Console.WriteLine($"Справу '{list[indexDone]}' успішно відмічено як виконану!");
                            }
                            else
                                Console.WriteLine("Справу за таким індексом ще не додано.");
                        }
                        else
                            Console.WriteLine("Введене значення не є числом!!!");
                        break;

                    case "3":
                        Console.WriteLine("Введіть порядковий номер справи (починаючи з нуля), яку треба видалити:");
                        string inputDeleteAction = Console.ReadLine();
                        if (int.TryParse(inputDeleteAction, out int indexDelete))
                        {
                            if (indexDelete >= 0 && indexDelete < list.Count)
                            {
                                list.RemoveAt(indexDelete);
                                completedIndices.Remove(indexDelete); 
                                Console.WriteLine($"Справу під номером {indexDelete} успішно видалено!");
                            }
                            else
                                Console.WriteLine("Справу за таким індексом ще не додано.");
                        }
                        else
                            Console.WriteLine("Введене значення не є числом!!!");
                        break;

                    case "4":
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Список справ ще пустий!");
                        }
                        else
                        {
                            Console.WriteLine("Ваш список справ:");
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (completedIndices.Contains(i))
                                {
                                    Console.ForegroundColor = ConsoleColor.Green; 
                                    Console.WriteLine($"{i}: {list[i]} (виконано)");
                                    Console.ResetColor(); 
                                }
                                else
                                {
                                    Console.WriteLine($"{i}: {list[i]}");
                                }
                            }
                        }
                        break;

                    case "5":
                        Console.WriteLine("До побачення!");
                        return;

                    default:
                        Console.WriteLine("Невідома команда. Спробуйте ще раз.");
                        break;
                }
            }
        }

        static void StartedScreen()
        {
            Console.Write("Вітаю! Для створення списку справ введіть назву списку: ");
            string nameOfList = Console.ReadLine();
            Console.WriteLine($"Список справ під назвою '{nameOfList}' створено.");
        }
        static void ShowMenu()
        {
            Console.WriteLine("\nВиберіть дію:");
            Console.WriteLine(" '1' - Додати справу");
            Console.WriteLine(" '2' - Відмітити виконання");
            Console.WriteLine(" '3' - Видалити справу");
            Console.WriteLine(" '4' - Показати список справ");
            Console.WriteLine(" '5' - Вийти");
        }
    }
}
