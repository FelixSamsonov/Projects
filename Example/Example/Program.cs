
using System.Text;

namespace example;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        var vcls = new List<Vehicle>
        {
            new Car("Mitsubishi", "Eclips", 28300, 4),
            new Bicycle("BMW", "El3"),
            new Motocycle("Kawasaki", "Eros", 13500, true)
        };
        Shop shop = new Shop();
        shop.AddVehicle(vcls);
        foreach (var v in vcls)
        {
            v.GetDescription();
        }
    }
}
