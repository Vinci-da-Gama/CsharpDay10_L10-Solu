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

            string str0 = "Wrapping up our basic Entity Framework and LINQ to Entities coverage";

        }
    }
}
