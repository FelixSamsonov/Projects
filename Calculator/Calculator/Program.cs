using System.Text;
Console.OutputEncoding = Encoding.UTF8;

while (true)
{
    Console.WriteLine("Введіть перше число для обчислення");
    string inputFirstNumber = Console.ReadLine();
    if (inputFirstNumber.ToLower() == "exit")
        break;


    if (byte.TryParse(inputFirstNumber, out byte bNum1))
    {
        Console.WriteLine("Ведіть математичну дію");
        string operation = Console.ReadLine();
        Console.WriteLine("Введіть друге число");
        string inputSecondNumber = Console.ReadLine();
        if (byte.TryParse(inputSecondNumber, out byte bNum2))
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Результат: {bNum1 + bNum2}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {bNum1 - bNum2}");
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine($"Результат: {bNum1 / bNum2}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("На нуль ділити не можна/" + ex.Message);
                    }
                    break;
                case "*":
                    Console.WriteLine($"Результат: {bNum1 * bNum2}");
                    break;
                default:
                    Console.WriteLine("Введена не математична дія");
                    break;
            }
        }
        else
        {
            Console.WriteLine($"Не корректний формат числа: '{inputSecondNumber}'");
        }
    }
    else if (short.TryParse(inputFirstNumber, out short sNum1))
    {
        Console.WriteLine("Ведіть математичну дію");
        string operation = Console.ReadLine();
        Console.WriteLine("Введіть друге число");
        string inputSecondNumber = Console.ReadLine();
        if (short.TryParse(inputSecondNumber, out short sNum2))
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Результат: {sNum1 + sNum2}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {sNum1 - sNum2}");
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine($"Результат: {sNum1 / sNum2}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("На нуль ділити не можна/" + ex.Message);
                    }
                    break;
                case "*":
                    Console.WriteLine($"Результат: {sNum1 * sNum2}");
                    break;
                default:
                    Console.WriteLine("Введена не математична дія");
                    break;
            }
        }
        else
        {
            Console.WriteLine($"Не корректний формат числа: '{inputSecondNumber}'");
        }
    }
    else if (int.TryParse(inputFirstNumber, out int iNum1))
    {
        Console.WriteLine("Ведіть математичну дію");
        string operation = Console.ReadLine();
        Console.WriteLine("Введіть друге число");
        string inputSecondNumber = Console.ReadLine();
        if (int.TryParse(inputSecondNumber, out int iNum2))
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Результат: {iNum1 + iNum2}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {iNum1 - iNum2}");
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine($"Результат: {iNum1 / iNum2}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("На нуль ділити не можна/" + ex.Message);
                    }
                    break;
                case "*":
                    Console.WriteLine($"Результат: {iNum1 * iNum2}");
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
    else if (decimal.TryParse(inputFirstNumber, out decimal dNum1))
    {
        Console.WriteLine("Ведіть математичну дію");
        string operation = Console.ReadLine();
        Console.WriteLine("Введіть друге число");
        string inputSecondNumber = Console.ReadLine();
        if (decimal.TryParse(inputSecondNumber, out decimal dNum2))
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Результат: {dNum1 + dNum2}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {dNum1 - dNum2}");
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine($"Результат: {dNum1 / dNum2}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("На нуль ділити не можна/" + ex.Message);
                    }
                    break;
                case "*":
                    Console.WriteLine($"Результат: {dNum1 * dNum2}");
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
    else
    {
        Console.WriteLine($"Не корректний формат числа '{inputFirstNumber}', спробуй ще");
        continue;
    }

}