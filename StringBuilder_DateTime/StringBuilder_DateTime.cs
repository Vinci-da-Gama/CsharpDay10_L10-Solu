using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_DateTime
{
    public class StringBuilder_DateTimeClass
    {
        public void ShowSbDt()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                sb.Append("-- ");
                sb.AppendLine(i.ToString()+" ");
            }
            Console.Write("19 {0}", sb.ToString());

            string Str0 = "HAHA-Wrapping up our basic Entity Framework and LINQ to Entities coverage";
            
            string Str1 = Str0.Substring(0, 10);
            string Str2 = Str0.Replace(" ", "^^^");
            Console.WriteLine(Str1+" -- "+Str2);
            Console.WriteLine(String.Format("Length Before: {0} -- After trim: {1}.", Str0.Length, Str0.Trim().Length));

            DateTime dt = DateTime.Now;
            string StrTime = dt.AddDays(-3).AddHours(3).AddMinutes(30).AddSeconds(100).AddYears(-1).ToString();
            Console.WriteLine("Time: {0}.", StrTime);

            DateTime dt0 = new DateTime(2009, 12, 18, 1,1,1);
            DateTime dt1 = DateTime.Parse("2010/01/18");

            Console.WriteLine("Date0: {0} -- Date1: {1}.", dt0.ToString(), dt1.ToString());

            DateTime dt2;
            if (DateTime.TryParse("2012/3/3", out dt2))
            {
                Console.WriteLine("\n40 -- Date: {0}.", dt2.ToShortDateString());
            }
            else {
                Console.WriteLine("Not a Valid Date...");
            }
            
        }
    }
}
