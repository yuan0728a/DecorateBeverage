using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateBeverage.Models
{
    public abstract class Beverage
    {
        private readonly string description = "Unknown Beverage";

        public Beverage(string descirption) { 
            description = descirption;
        }


        public string GetDescription() {
            Console.WriteLine(description);
            return description;
        }

        public abstract double Cost();

    }
}
