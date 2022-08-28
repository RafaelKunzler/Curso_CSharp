using Aula155.Entities;
using Aula155.Entities.Exceptions;

namespace Aula155
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, limit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
            try
            {
                account.Withdraw(amount);
                Console.WriteLine("New balance : " + account.Balance.ToString("F2"));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}