using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Models;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            Product product2 = new Product();

            product1.SetName("Shampoo");
            product1.SetPrice(500);
            product1.SetId(32165);
            product1.SetDiscount(10);
            
             
            product2.SetName("Soap");
            product2.SetPrice(60);
            product2.SetId(81564);
            product2.SetDiscount(15);

            PrintItems(product1);
            PrintItems(product2);



        }

        public static void PrintItems(Product product)
        {
            Console.WriteLine($"Product1 name: {product.GetName()}");
            Console.WriteLine($"Product1 price: {product.GetPrice()}");
            Console.WriteLine($"Product1 id: {product.GetId()}");
            Console.WriteLine($"Product1 discount: {product.GetDiscount()}");
            Console.WriteLine($"Product1 price after discount: {product.CalculatePriceAfterDiscount()}");
        }



    }
}
