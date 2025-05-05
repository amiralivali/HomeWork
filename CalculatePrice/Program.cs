using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePrice
{
    internal class Program
    {
        static double CalculatePrice(double price, double tax = 0.1, double discount = 0.05)
        {
            tax *= price;
            discount *= price;
            double finalPrice = price + tax - discount;
            return finalPrice;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter price?");
            double price=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter tax?");
            double tax = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter discount?");
            double discount = double.Parse(Console.ReadLine());
            double finalPrice = CalculatePrice(price, tax ,discount);
            Console.WriteLine(finalPrice);
            Console.ReadLine();
        }
    }
}
