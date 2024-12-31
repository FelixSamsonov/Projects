using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example;

public class Shop
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(List<Vehicle> newVehicle)
    {
        newVehicle.AddRange(newVehicle);
    }

    public void ShowVehicle()
    {
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine("List of Vehicle: ");
            vehicle.GetDescription();
        }
    }
}
