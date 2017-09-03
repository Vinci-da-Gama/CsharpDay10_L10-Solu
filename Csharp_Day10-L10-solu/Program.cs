using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringBuilder_DateTime;
using Auto_Mobile;

using Csharp_Day10_L10_solu.TaxManager;

namespace Csharp_Day10_L10_solu
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder_DateTimeClass sbdtc = new StringBuilder_DateTimeClass();
            sbdtc.ShowSbDt();

            AutoMobileCar abc = new AutoMobileCar("Make0", "Model0", 2010, ConditionEnumeration.Good);
            AutoMobileService ams = new AutoMobileService();
            Day10_SoluEntities dsem = new Day10_SoluEntities();
            Automobel ab = new Automobel()
            {
                Make = ams.ReturnNewCar(abc).Make,
                Model = abc.Model,
                Year = (Int16)abc.Year,
                Condition = abc.Condition.ToString()
            };

            var aa = from i in dsem.Automobels
                     where i.Make == "Make0"
                     select i;

            if (aa != null)
            {
                Console.WriteLine("This car is existed.");
            }
            else
            {
                dsem.Automobels.Add(ab);
                dsem.SaveChanges();
            }

            var ao0 = from a in dsem.Automobels
                     where a.Make == "Make0"
                     select a;
            foreach (var i in ao0)
            {
                Console.WriteLine("\n48 -- Year: {0} -- Id: {1}.", i.Year, i.AutoId);
            }

            Console.WriteLine("Please input Sales Amount...");
            string InputedSalesAmount = Console.ReadLine();
            decimal SalesAmt = decimal.Parse(InputedSalesAmount);

            TaxManagerClass tmc = new TaxManagerClass(SalesAmt);
            decimal TaxRz = tmc.CalculateTax();
            Console.WriteLine("\n59 -- Tax: {0}.", TaxRz);

            Console.ReadLine();

        }
    }
}
