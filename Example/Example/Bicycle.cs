using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace example;

    public class Bicycle : Vehicle
    {
    public Bicycle(string brand, string model) : base(brand, model, 1)
    {
        Brand = brand;
        Model = model;
    }
    public override void GetDescription()
    {
        Console.WriteLine($"The bicycle, which has: brand \"{Brand}\", model \"{Model}\" is cost: Free");
    }
}

