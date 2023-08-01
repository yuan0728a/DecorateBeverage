using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateBeverage.Models
{
    public class Decaf : Beverage
    {
        private const double DECAFCOST = 21;

        public Decaf(string description) : base(description)
        {
        }

        public override double Cost()
        {
            Console.WriteLine($"cost is {DECAFCOST}");
            return DECAFCOST;
        }

    }
}
