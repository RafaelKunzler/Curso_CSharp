using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula146.Entities
{
    internal class CompanyTax : TaxPayer
    {
        public int Employees { get; set; }

        public CompanyTax(string name, double anualIncome, int employees) : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double Taxes()
        {
            double taxes = 0;
            if(Employees > 10)
            {
                taxes += AnualIncome * 0.14;
            } else
            {
                taxes += AnualIncome * 0.16;
            }
            return taxes;
        }
    }
}
