
using System.Text;
using VegetableShopApp;

namespace vegetableShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var products = new List<Product>
            {
                new Carrot(45.3m),
                new Tomato(85.35m),
                new Potato(17.23m, 7),
                new Cucumber(23.23m, 5)
            };

            VegetableShop shop = new VegetableShop();
            shop.AddProducts(products);

            shop.PrintProductsInfo();

            Console.WriteLine($"Загальна ціна всіх продуктів: {shop.CalculateTotalPrice()} грн.");
        }
    }
}
