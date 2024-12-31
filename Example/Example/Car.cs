using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example;

public class Car : Vehicle, IPurchasable
{
    private int numberOfDors;

    public Car(string brand, string model, decimal price,  int numberOfDors) : base ( brand, model, price)
    {
        NumberOfDors = numberOfDors;
    }
    public int NumberOfDors
    {
        get {  return numberOfDors; }
        set 
        {
            if (value >= 2)
                numberOfDors = value;
            else
                throw new Exception("Car has to has more than 1 door");
        }
    }
    public override void GetDescription()
    {
        Console.WriteLine($"The car, which has: brand \"{Brand}\", model \"{Model}\" and \"{NumberOfDors}\" doors is cost: {Price} dollars");
    }
    public void IsBought()
    {
        Console.WriteLine("The car was bought");
    }
}
