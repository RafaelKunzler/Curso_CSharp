using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula140.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHours, double additionalCharge) 
            : base(name, hours, valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHours = valuePerHours;
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
           return base.Payment() + 1.1 * AdditionalCharge;

        }



    }


}
