using System;
using System.Collections.Immutable;
using System.Text;

namespace ArraysSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ////1.

            Random random = new Random();
            int[] array = new int[10];
            Console.WriteLine("Початковий масив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            //bool sort = false;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sort = true;
            //    for (int j = 0; j < array.Length - 1; j++)
            //    {
            //        if (array[j] > array[j + 1])
            //        {
            //            (array[j], array[j + 1]) = (array[j + 1], array[j]);
            //            sort = false;
            //        }
            //    }
            //    if (sort)
            //    {
            //        break;
            //    }
            //}

            // ВАРІАНТ НОМЕР ДВА
            Array.Sort(array);
            Console.WriteLine();
            Console.WriteLine("Передостанній найбільший елемент в масиві " + array[array.Length - 2] + "\t");



            //2.

            //Random random = new Random();
            //int[,] twoDimencionalArray = new int[10, 10];
            //Console.WriteLine("Початковий масив: ");
            //for (int i = 0; i < twoDimencionalArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < twoDimencionalArray.GetLength(1); j++)
            //    {
            //        twoDimencionalArray[i, j] = random.Next(-100, 100);
            //        Console.Write(twoDimencionalArray[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //int[] oneDimencionalArray = twoDimencionalArray.Cast<int>().ToArray();
            //Array.Sort(oneDimencionalArray);
            //int index = 0;
            //for (int i = 0; i < twoDimencionalArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < twoDimencionalArray.GetLength(1); j++)
            //    {
            //        twoDimencionalArray[i, j] = oneDimencionalArray[index];
            //        index++;
            //    }
            //}
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Відсортований масив: ");
            //for (int i = 0; i < twoDimencionalArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < twoDimencionalArray.GetLength(1); j++)
            //    {
            //        Console.Write(twoDimencionalArray[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ResetColor();


            //3
            //Console.Write("Введіть на яку кількість елементів створюємо масив: ");
            //if (int.TryParse(Console.ReadLine(), out int inputEl))
            //{
            //    Random random = new Random();
            //    int[] array = new int[inputEl];

            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        array[i] = random.Next(-100, 100);
            //        Console.Write(array[i] + "\t");
            //    }
            //    Console.WriteLine();
            //    Console.Write("Введіть індекс елементу, який треба видалити: ");
            //    if (int.TryParse(Console.ReadLine(), out int removeIndex))
            //    {
            //        if (removeIndex >= 0 && removeIndex < array.Length)
            //        {
            //            int[] newArray = new int[array.Length - 1];
            //            int newIndex = 0;
            //            for (int i = 0; i < array.Length; i++)
            //            {
            //                if (i != removeIndex)
            //                {
            //                    newArray[newIndex] = array[i];
            //                    newIndex++;
            //                }
            //            }

            //            Console.WriteLine("Масив після видалення елемента:");
            //            for (int i = 0; i < newArray.Length; i++)
            //            {
            //                Console.Write(newArray[i] + "\t");
            //            }
            //            Console.WriteLine();
            //            Console.Write($"Видалений елемент:  '{array[removeIndex]}'");
            //            Console.WriteLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ви вийшли за діапазон масиву");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Введене не числове значення");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Введене не числове значення");
            //}

            //4 

            //Console.Write("Введіть розмір масиву: ");
            //if (int.TryParse(Console.ReadLine(), out int result))
            //{
            //    Random random = new Random();
            //    int[,] array = new int[result, result];
            //    Console.WriteLine("Початковий масив: ");
            //    for (int i = 0; i < array.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array.GetLength(1); j++)
            //        {
            //            array[i, j] = random.Next(-100, 100);
            //            Console.Write(array[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }

            //    int n = array.GetLength(0);
            //    int firstDiagonalSum = 0;
            //    int secondDiagonalSum = 0;

            //    for (int i = 0; i < n; i++)
            //    {
            //        firstDiagonalSum += array[i, i];
            //        secondDiagonalSum += array[i, n - i - 1];
            //    }

            //    Console.WriteLine("Сума лівої діагоналі: " + firstDiagonalSum);
            //    Console.WriteLine("Сума правої діагоналі: " + secondDiagonalSum);

            //}
            //else
            //{
            //    Console.WriteLine("Введне не числове значення!!!");
            //}
        }
    }
}



