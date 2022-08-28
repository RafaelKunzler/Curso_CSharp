using Aula140.Entities;

namespace Aula140
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();


            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsorced (y/n)? ");
                char yn = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (yn == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employeeList.Add(employee);
                }
                else
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employeeList.Add(employee);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            
            foreach(Employee employee in employeeList)
            {
                Console.WriteLine(employee);
            }





        }
    }
}