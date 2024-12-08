using System.Text;


namespace CheckNameSurname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Ведіть ваше ім'я та призвіще");
            string inputNameSurname = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputNameSurname) && !string.IsNullOrEmpty(inputNameSurname))
            {
                char[] nameSurname = inputNameSurname.ToCharArray();
                for (int i = 0; i < nameSurname.Length; i++)
                {
                    if (nameSurname[i] == ' ')
                    {
                        if (nameSurname[0] == nameSurname[i + 1])
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
    }
}

//namespace RemoveSpaces
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введіть текст");
//            string inputText = Console.ReadLine();
//            string outputText = inputText.Replace(" ", "");
//            Console.WriteLine(outputText);
//        }
//    }
//}
