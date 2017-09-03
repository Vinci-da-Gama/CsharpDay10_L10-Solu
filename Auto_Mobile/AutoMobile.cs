using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Mobile
{
    public class AutoMobileCar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public ConditionEnumeration Condition { get; set; }
        public AutoMobileCar(string m, string mo, int y, ConditionEnumeration ce)
        {
            Make = m;
            Model = mo;
            Year = y;
            Condition = ce;
        }
    }

    public class AutoMobileService
    {
        public AutoMobileCar ReturnNewCar(AutoMobileCar car)
        {
            return car;
        }
    }

    public enum ConditionEnumeration
    {
        Mint,
        Good,
        Fair,
        Bad,
        Totalled
    }
}
