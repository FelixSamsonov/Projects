using System.Text;
Console.OutputEncoding = Encoding.UTF8;

while (true)//щоб постійно не перезапускати консоль
{
    Console.WriteLine("Введіть число від 1-7");
    string numberEntered = Console.ReadLine();
    if (numberEntered.ToLower() == "exit") 
    {
        break;

    }
    int day = int.Parse(numberEntered);
    switch (day)
    {
        case 1:
            Console.WriteLine("Понеділок");
            break;
        case 2:
            Console.WriteLine("Вівторок");
            break;
        case 3:
            Console.WriteLine("Середа");
            break;
        case 4:
            Console.WriteLine("Четвер");
            break;
        case 5:
            Console.WriteLine("Пятниця");
            break;
        case 6:
            Console.WriteLine("Субота");
            break;
        case 7:
            Console.WriteLine("Неділя");
            break;
        default:
            Console.WriteLine("Введене число не підходить по параметрам");
            break;
    }
}







