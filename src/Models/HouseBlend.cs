using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateBeverage.Models
{
    public class HouseBlend : Beverage
    {
        private const double HOUSEBLENDCOST = 22;

        public HouseBlend(string description) : base(description)
        {
        }

        public override double Cost()
        {
            Console.WriteLine($"cost is {HOUSEBLENDCOST}");
            return HOUSEBLENDCOST;
        }

    }
}
