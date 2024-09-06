using System;
using System.Globalization;

namespace FirstProject {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Product[] products = new Product[n];

            double[] values = {1, 2 ,3 ,4};

            for (int i = 0; i < n; i++) {
                string? name = Console.ReadLine();
                double? price = double.Parse(Console.ReadLine());

                products[i] = new Product(name, price.GetValueOrDefault());
            }

            double totalPrice = 0;
            for (int i = 0; i < n; i++) {
                totalPrice += products[i].Price;
            }
            Console.WriteLine($"AVERAGE PRICE = {totalPrice/n}");
        }
    }
}