using System.Text;
Console.OutputEncoding = Encoding.UTF8;

while (true)
{
    Console.WriteLine("Введіть перше число для обчислення");
    string inputFirstNumber = Console.ReadLine();
    if (inputFirstNumber.ToLower() == "exit")
    {
        break;
    }
    decimal firstNumber;
    if (decimal.TryParse(inputFirstNumber, out firstNumber))
    {
        Console.WriteLine("Ведіть математичну дію");
    }
    else
    {
        Console.WriteLine($"Не корректний формат числа '{inputFirstNumber}', спробуй ще");
        continue;
    }
    string operation = Console.ReadLine();
    Console.WriteLine("Введіть друге число");
    string inputSecondNumber = Console.ReadLine();
    decimal secondNumber;
    if (decimal.TryParse(inputSecondNumber, out secondNumber))
    {
        switch (operation)
        {
            case "+":
                Console.WriteLine($"Результат: {firstNumber + secondNumber}");
                break;
            case "-":
                Console.WriteLine($"Результат: {firstNumber - secondNumber}");
                break;
            case "/":
                try
                {
                    Console.WriteLine($"Результат: {firstNumber / secondNumber}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("На нуль ділити не можна/" + ex.Message);
                }
                break;
            case "*":
                Console.WriteLine($"Результат: {firstNumber * secondNumber}");
                break;
            default:
                Console.WriteLine("Введена не математична дія");
                break;
        }
    }
    else
    {
        Console.WriteLine($"Не корректний формат числа '{inputSecondNumber}'");
    }
}