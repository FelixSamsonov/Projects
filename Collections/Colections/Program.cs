using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;


//1. 

int[] array = new int[10];
Random random = new Random();
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 11);
}
for (int j = 2; j < array.Length; j += 2)
{
    Console.WriteLine($"індекс {j} - значення: {array[j]}");
    //2
    sum += array[j];
}
if (sum >= 0)
{
    Console.WriteLine("Сума масиву невід'ємна - " + true);
}
else
{
    Console.WriteLine("Сума масиву від'ємна - " + false);
}

//3.
//int[,] array2d = new int[9, 9];
//for (int i = 0; i < array2d.GetLength(0); i++)
//{
//    for (int j = 0; j < array2d.GetLength(1); j++)
//    {
//        array2d[i, j] = (i + 1) * (j + 1);
//        Console.Write($"{array2d[i, j],3} ");
//    }
//    Console.WriteLine();
//}

//4.

//int[,] array1 = new int[5, 5];
//Random random = new Random();
//int max = array1[0, 0];
//int min = array1[0, 0];
//int maxRow = 0;
//int maxCol = 0;
//int minCol = 0;
//int minRow = 0;
//for (int i = 0; i < array1.GetLength(0); i++)
//{
//    for (int j = 0; j < array1.GetLength(1); j++)
//    {
//        array1[i, j] = random.Next(-100, 100);
//        if (array1[i, j] > max)
//        {
//            max = array1[i, j];
//            maxRow = i;
//            maxCol = j;
//        }
//        if (array1[i, j] < min)
//        {
//            min = array1[i, j];
//            minRow = i;
//            minCol = j;
//        }
//        Console.Write($"{array1[i, j],3} ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine($"Максимальний елемент у масиві: {max} " +
//    $"\nКоординати максимального елементу у масиві: рядок: {maxRow}," +
//    $" стовпчик: {maxCol}" +
//    $"\nМінімальний елемент у масиві: {min}" +
//    $"\nКоординати мінімального елементу у масиві - рядок: {minRow}," +
//    $" стовпчик: {minCol}");

//5

//Console.WriteLine("Введіть число");
//int.TryParse(Console.ReadLine(), out int number);
//daysOfWeek start = daysOfWeek.Monday;
//daysOfWeek futureDay = (daysOfWeek)((number % 7 + (int)start) % 7);
//Console.WriteLine($"Через {number} днів буде {futureDay}");
//enum daysOfWeek
//{
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
//}

