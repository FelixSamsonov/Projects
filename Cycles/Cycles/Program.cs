using System;
using System.Text;
using System.Text.RegularExpressions;
Console.OutputEncoding = Encoding.UTF8;


//1.
Console.WriteLine("Ведіть зарплати ваших робітників, після завершення введіть 'end'");
int count = 0;
decimal sum = 0;
while (true)
{
    string inputSalary = Console.ReadLine();
    if (inputSalary.ToLower() == "end")
        break;
    if (decimal.TryParse(inputSalary, out decimal salary))
    {
        count++;
        sum += salary;
    }
    else
    {
        Console.WriteLine("Введене не числове значення");
    }
}
Console.WriteLine("Середня заробітня плата = " + (sum / count));


//2
//Console.WriteLine("Введіть число");
//string inputNum = Console.ReadLine();
//if (int.TryParse(inputNum, out int num))
//{
//    for (int i = 1; i <= num; i++)
//    {
//        for (int j = 1; j <= i; j++)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//}
//else
//{
//    Console.WriteLine("не вірний вводу");
//}


//3
//Console.WriteLine("Введіть число");
//int.TryParse(Console.ReadLine(), out int number);
//Console.Write("Прості числа в заданому діапазоні: ");
//for (int i = 2; i <= number; i++)
//{
//    bool isPrime = true;

//    for (int j = 2; j * j <= i; j++)
//    {
//        if (i % j == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }

//    if (isPrime)
//    {
//        Console.Write($"{i} ");
//    }
//}


//4
//Console.WriteLine("Ведіть пароль(повинен містити 8 символів, з них хоча б 1 велику літеру, спеціальний символ та цифру): ");
//while (true)
//{
//    string inputParol = Console.ReadLine();
//    bool containsNumber = Regex.IsMatch(inputParol, @"\d+");
//    bool containsLetter = Regex.IsMatch(inputParol, @"[a-zA-Z]");
//    bool isUpperLetter = Regex.IsMatch(inputParol, "[A-Z]");
//    bool specialChar = Regex.IsMatch(inputParol, @"[^a-zA-Z0-9]");

//    if (inputParol.Length >= 8)
//    {
//        if (containsNumber == true)
//        {
//            if (containsLetter == true)
//            {
//                if (specialChar == true)
//                {
//                    if (isUpperLetter == true)
//                    {
//                        Console.WriteLine("Пароль прийнято");
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Не вірний формат вводу(пароль повинен містити хоча б одну велику літеру)");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Не вірний формат вводу(не містить спеціальних символів)");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Не вірний формат вводу(не містить букв)");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Не вірний формат вводу(не має числових значень)");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Пароль повинен містити мінімум 8 символів");
//    }
//}


//5
//Console.WriteLine("Скільки чисел послідовності Фібоначчо ви хочете вивести?");
//if (uint.TryParse(Console.ReadLine(), out uint number)) 
//{
//    uint firstNum = 0;
//    uint secondNum = 1;

//    Console.WriteLine("Послідовність Фібоначчо:");
//    for (int i = 0; i < number; i++)
//    {
//        Console.Write(firstNum + " ");
//        uint fibonachi = firstNum;
//        firstNum = secondNum;
//        secondNum = fibonachi + secondNum;
//    }
//}
//else
//{
//    Console.WriteLine("Введене значення не є числовим, або від'ємне");
//}


//6. (Написав програму, але без циклу. Тому зробив в такому вигляді, щоб використовувався цикл)
//Console.Write("Введіть вашу оплату за годину: ");
//string inputSalary = Console.ReadLine();
//if (decimal.TryParse(inputSalary, out decimal salary))
//{
//    Console.Write("Введіть кількість відпрацьованих годин: ");
//    string inputHour = Console.ReadLine();
//    if (decimal.TryParse(inputHour, out decimal hour))
//    {
//        for (int i = 1; i <= hour; i++)
//        {
//            if (i == 1)
//                Console.WriteLine($"Ваша заробітня плата за {i} годину:  {salary * i} гривень");
//            if (i > 1 && i < 5)
//                Console.WriteLine($"Ваша заробітня плата за {i} години:  {salary * i} гривень");
//            if (i >= 5)
//                Console.WriteLine($"Ваша заробітня плата за {i} годин:  {salary * i} гривень");
//        }
//    }
//    else
//    {
//        Console.WriteLine("не вірний формат вводу");
//    }
//}
//else
//{
//    Console.WriteLine("не вірний формат вводу");
//}


//7.
//Console.Write("Введіть число: ");
//string inputNum = Console.ReadLine();
//if (int.TryParse(inputNum, out int num))
//{
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine(i * num);
//    }
//}
//else
//{
//    Console.WriteLine("невірний формат числа");
//}


//8
//Console.Write("Введіть число для перевірки на простоту: ");
//if (uint.TryParse(Console.ReadLine(), out uint number))
//{
//    if (number < 2)
//        Console.WriteLine("Не є простим числом");
//    else
//    {
//        bool isPrime = true;
//        for (int i = 2; i * i <= number; i++)
//        {
//            if (number % i == 0)
//            {
//                isPrime = false;
//                break;
//            }
//        }
//        if (isPrime)
//            Console.WriteLine($"{number} є простим");
//        else
//        {
//            Console.WriteLine($"{number} не є простим");
//        }
//    }

//}
//else
//{
//    Console.WriteLine("Введене значення не є числом, або від'ємне!");
//}




