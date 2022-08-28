using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula142.Entities
{
    internal class ImportedProduct : Product
    {
        public double CostomsFee { get; set; }

        public ImportedProduct(string name, double price, double productFee) 
            : base(name, price)
        {
            CostomsFee = productFee;
        }

        public double TotalPrice()
        {
            return CostomsFee + Price;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(TotalPrice().ToString("F2"));
            sb.Append(" (Customs fee: $ ");
            sb.Append(CostomsFee);
            sb.Append(")");
            return sb.ToString();
            
        }

    }
}
