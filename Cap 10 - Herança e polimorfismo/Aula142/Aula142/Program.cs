using Aula142.Entities;

namespace Aula142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Costoms fee: ");
                    double costomsFee = double.Parse(Console.ReadLine());
                    productList.Add(new ImportedProduct(name, price, costomsFee));


                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    productList.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    productList.Add(new Product(name, price));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in productList)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}