using System.Diagnostics;

namespace Q1
{
    internal class Program
    {
        public class Product
        {
            public Product() { 
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
                Console.Write("enter product name: ");
                Name = Console.ReadLine();

                Console.Write("enter product price: ");
                price = Convert.ToDouble(Console.ReadLine());

                Console.Write("enter product discount: ");
                discount =  Convert.ToDouble( Console.ReadLine() );
            }

            public override string? ToString()
            {
                return base.ToString();
            }
        }

        static void Main(string[] args)
        {   

            Product p = new Product();
            p.input();
            p.display();
            
        }
    }
}