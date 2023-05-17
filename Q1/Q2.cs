using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Q2
    {

        public class Product
        {
            public Product()
            {
            }
            public Product(string name, double price, double discount)
            {
                Name = name;
                this.price = price;
                this.discount = discount;
            }

            public string Name { get; set; }
            public double price { get; set; }
            public double discount { get; set; }


            public double getImportTax(double price)
            {
                double i = price * 0.1;
                return i;
            }
            public void display()
            {
                Console.WriteLine($"Name:{Name}");
                Console.WriteLine($"Price:{price}");
                Console.WriteLine($"Discount:{getImportTax(price)}");
            }
            public void input()
            {
                Console.Write("Enter product name: ");
                Name = Console.ReadLine();

                Console.Write("Enter product price: ");
                price = Convert.ToDouble(Console.ReadLine());

            }

            public void run()
            {
                Product p1 = new Product();
                Product p2 = new Product();
                Console.WriteLine("Product1");
                p1.input();
                Console.WriteLine("Product2");
                p2.input();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Product 1");
                p1.display();
                Console.WriteLine("Product 2");
                p2.display();
            }

        }

        static void Main(string[] args)
        {
            Product product = new Product();
            product.run();

        }
    }
}
