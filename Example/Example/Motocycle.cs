using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example;

public class Motocycle : Vehicle, IPurchasable
{
    public bool HasSidecar { get; set; }

    public Motocycle(string brand, string model, decimal price, bool hasSidecar) : base(brand, model, price)
    {
        HasSidecar = hasSidecar;
    }
    public override void GetDescription()
    {
        if (HasSidecar == true)
            Console.WriteLine($"With sidecar The motocycle which has: brand \"{Brand}\", model \"{Model}\" is cost: {Price + 1000} dollars");

        else
            Console.WriteLine($"The motocycle which has: brand \"{Brand}\", model \"{Model}\" is cost: {Price} dollars");
    }
    public void IsBought()
    {
        Console.WriteLine("The car was bought");
    }
}

