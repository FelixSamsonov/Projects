using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example;

public class Vehicle
{
    private string brand;
    private string model;
    private decimal price;

    public Vehicle(string brand, string model, decimal price)
    {
        Brand = brand;
        Model = model;
        Price = price;
    }
    public string Brand
    {
        get { return brand; }

        set 
        {
            if (!string.IsNullOrEmpty(value))
                brand = value;
            else
                throw new ArgumentException("Brand has to has \"brand\"");
        }
    }
    public string Model
    {
        get { return model; }

        set
        {
            if (!string.IsNullOrEmpty(value))
                model = value;
            else
                throw new ArgumentException("Brand has to has \"model\"");
        }
    }
    public decimal Price
    {
        get { return price; }

        set
        {
            if (value > 0)
                price = value;
            else
                throw new ArgumentException("Prise has to be more than 0");
        }
    }

    public virtual void GetDescription()
    {

    }
}
