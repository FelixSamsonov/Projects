using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableShopApp;

namespace vegetableShop
{
    public class VegetableShop
    {
        private List<Product> products = new List<Product>();

        public void AddProducts(List<Product> newProducts)
        {
            products.AddRange(newProducts);
        }

        public void PrintProductsInfo()
        {
            Console.WriteLine("Продукти:");
            foreach (var product in products)
            {
                product.GetInfo();
            }
        }

        public decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.Price;
            }
            return total;
        }
    }
}
