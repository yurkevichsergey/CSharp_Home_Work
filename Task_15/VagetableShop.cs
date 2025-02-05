using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VegetableShop
{
    private List<Product> products = new List<Product>();

    public void AddProducts(List<Product> newProducts)
    {
        products.AddRange(newProducts);
    }

    public void PrintProductsInfo()
    {
        Console.WriteLine("Available products in the shop:");
        double totalCost = 0;
        foreach (var product in products)
        {
            Console.WriteLine(product.Info);
            totalCost += product.Price;
        }
        Console.WriteLine($"Total price of all products: {totalCost} UAH");
    }
}
