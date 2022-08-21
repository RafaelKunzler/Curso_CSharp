using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio1.Entities.Enum;

namespace Exercicio1.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract Contract)
        {
            Contracts.Add(Contract);
        }

        public void RemoveContract(HourContract Contract)
        {
            Contracts.Remove(Contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract Contract in Contracts)
            {
                if(Contract.Date.Year == year && Contract.Date.Month == month)
                {
                    sum += Contract.TotalValue();
                }
            }
            return sum;
        }


    }
}
