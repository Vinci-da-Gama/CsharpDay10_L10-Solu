using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Day10_L10_solu.TaxManager
{
    class TaxManagerClass
    {
        public decimal SalesAmount { get; set; }
        private DateTime SalesDate { get; set; }
        private decimal TaxAmount { get; set; }
        public TaxManagerClass(decimal sa)
        {
            SalesAmount = sa;
        }
        public decimal CalculateTax()
        {
            Random rnum = new Random();
            int rn = -(rnum.Next(1, 100));
            this.SalesDate = DateTime.Now.AddDays(rn);
            this.TaxAmount = SalesAmount * 0.0825M;
            return this.TaxAmount;
        }
    }
}
