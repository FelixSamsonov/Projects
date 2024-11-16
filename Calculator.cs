
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
while (true)//щоб не перезапускати постійно консоль
{
    Console.WriteLine("Введіть перше число для обчислення");
    string enteredFirstNumber = Console.ReadLine();
    if (enteredFirstNumber.ToLower() == "exit")
    {
        break;
    }
    decimal firstNumber = decimal.Parse(enteredFirstNumber);// в decimal, щоб могло
                                                            // обислювати і не цілі числа
    Console.WriteLine("Ведіть математичну дію");
    string enteredlOperation = Console.ReadLine();
    char operation = char.Parse(enteredlOperation);
    Console.WriteLine("Введіть друге число");
    string enteredSecondNumber = Console.ReadLine();
    decimal secondNumber = decimal.Parse(enteredSecondNumber);

    switch (operation)
    {
        case '+':
         Console.WriteLine($"Результат: {firstNumber + secondNumber}");
            break;

        case '-': 
         Console.WriteLine($"Результат: {firstNumber - secondNumber}");
            break;
        case '*':
         Console.WriteLine($"Результат: {firstNumber * secondNumber}"); 
            break;
        case '/': if (secondNumber == 0)
            {
         Console.WriteLine("Ділити на нуль не можна");
            }
            else
            {
         Console.WriteLine($"Результат: {firstNumber / secondNumber}");
            }
                break;
            }
    
}

