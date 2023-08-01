using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateBeverage.Models
{
    public class DarkRoast : Beverage
    {
        private const double DARKROASTCOST = 23;
        public DarkRoast(string description) : base(description)
        {
        }

        public override double Cost() {
            Console.WriteLine($"cost is {DARKROASTCOST}");
            return DARKROASTCOST;
        }
    }
}
