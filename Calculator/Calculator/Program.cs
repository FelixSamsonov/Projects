using System.Text;
Console.OutputEncoding = Encoding.UTF8;

while (true)//щоб не перезапускати постійно консоль
{
    Console.WriteLine("Введіть перше число для обчислення");
    string inputFirstNumber = Console.ReadLine();
    if (inputFirstNumber.ToLower() == "exit")
    {
        break;
    }
    decimal firstNumber = decimal.Parse(inputFirstNumber);                                                     
    Console.WriteLine("Ведіть математичну дію");
    string operation = Console.ReadLine();
    Console.WriteLine("Введіть друге число");
    string inputSecondNumber = Console.ReadLine();
    decimal secondNumber = decimal.Parse(inputSecondNumber);

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
            catch (Exception ex)
            {
                Console.WriteLine("На нуль ділити не можна: " + ex.Message);
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

