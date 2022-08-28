using Aula146.Entities;

namespace Aula146
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayersList = new List<TaxPayer>();


            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());

                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine());
                    taxPayersList.Add(new IndividualTax(name, income, healthExpenditure));
                    
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    taxPayersList.Add(new CompanyTax(name, income, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            
            foreach (TaxPayer taxPayer in taxPayersList)
            {
                Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Taxes().ToString("F2"));

            }

            Console.WriteLine();
            double totalTaxes = 0;
            foreach(TaxPayer taxPayer in taxPayersList)
            {
                totalTaxes += taxPayer.Taxes();                
            }
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2"));


        }
    }
}