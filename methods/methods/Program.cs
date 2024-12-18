using System.Text;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть індекс числа послідовності Фібоначчі");
            if (int.TryParse(Console.ReadLine(), out int numb))
            {
                Console.WriteLine($"Число Фібоначчі для індексу {numb}: {OrderFibonachi.Fibonachi(numb)}");
            }
            else
            {
                Console.WriteLine("Введене не числове значення !!!");
            }
        }

    }
    public class OrderFibonachi
    {
        public static int Fibonachi(int numb)
        {
            if (numb < 0)
                throw new ArgumentException(nameof(numb));
            if (numb == 0) return 0;
            if (numb <= 3) return 1;

            return Fibonachi(numb - 1) + Fibonachi(numb - 2);
        }
    }

}

