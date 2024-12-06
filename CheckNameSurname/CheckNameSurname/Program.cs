using System.Text;


namespace CheckNameSurname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Ведіть ваше ім'я");
            string inputName = Console.ReadLine();
            Console.WriteLine("Введіть ваше призвіще");
            string inputSurname = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputName) && !string.IsNullOrEmpty(inputSurname))
            {
                char[] firstName = inputName.ToCharArray();
                char[] firstSurname = inputSurname.ToCharArray();
                char firstLetterName = firstName[0];
                char firstLetterSurname = firstSurname[0];
                if (firstLetterName.ToString() == firstLetterSurname.ToString())
                {
                    Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
                }
                else
                {
                    Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
                }

            }

        }
    }
}
