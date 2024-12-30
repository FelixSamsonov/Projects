using System;
using System.Collections.Generic;

namespace VegetableShopApp
{
    public abstract class Product
    {
        private decimal basePrice;

        public string Name { get; }
        public decimal BasePrice
        {
            get { return basePrice; }
            set
            {
                if (value > 0)
                    basePrice = value;
                else
                    throw new ArgumentException("Ціна має бути більше 0.");
            }
        }

        public Product(string name, decimal basePrice)
        {
            Name = name;
            BasePrice = basePrice;
        }

        public virtual decimal Price => BasePrice;

        public virtual void GetInfo()
        {
            Console.WriteLine($"Продукт: {Name}, Ціна: {Price} грн.");
        }
    }

    public class Carrot : Product
    {
        public Carrot(decimal basePrice) : base("Морква", basePrice) { }
    }
    public class Tomato : Product
    {
        public Tomato(decimal basePrice) : base("Помідори", basePrice) { }
    }


    public class Potato : Product
    {
        public decimal Count { get; }

        public Potato(decimal basePrice, decimal count) : base("Картопля", basePrice)
        {
            if (count > 0)
                Count = count;
            else
                throw new ArgumentException("Кількість має бути більше 0.");
        }

        public override decimal Price => BasePrice * Count;

        public override void GetInfo()
        {
            Console.WriteLine($"Продукт: {Name}, Ціна за кг: {BasePrice} грн., Кількість(кг): {Count}, Загальна ціна: {Price} грн.");
        }
    }
    public class Cucumber : Product
    {
        public decimal Count { get; }

        public Cucumber(decimal basePrice, decimal count) : base("Огірки", basePrice)
        {
            if (count > 0)
                Count = count;
            else
                throw new ArgumentException("Кількість має бути більше 0.");
        }

        public override decimal Price => BasePrice * Count;

        public override void GetInfo()
        {
            Console.WriteLine($"Продукт: {Name}, Ціна за кг: {BasePrice} грн., Кількість(кг): {Count}, Загальна ціна: {Price} грн.");
        }
    }
}
