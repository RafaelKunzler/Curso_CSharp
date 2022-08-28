using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula146.Entities
{
    internal class IndividualTax : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public IndividualTax(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            double taxes = 0;
            if(AnualIncome < 20000)
            {
                taxes += AnualIncome * 0.15;
            } else
            {
                taxes += AnualIncome * 0.25;
            }

            if(HealthExpenditures > 0)
            {
                taxes -= HealthExpenditures * 0.5;
            }

            return taxes;

        }
    }
}
