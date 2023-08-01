// See https://aka.ms/new-console-template for more information
using DecorateBeverage.Models;
using Microsoft.VisualBasic;

class Program {
    static void Main(string[] args)
    {
        Beverage darkRoast = new DarkRoast("Dark Roast");
        darkRoast.GetDescription();
        darkRoast.Cost();

        Beverage decaf = new Decaf("Decaf");
        decaf.GetDescription();
        decaf.Cost();

        Beverage houseBlend = new HouseBlend("HouseBlend");
        houseBlend.GetDescription();
        houseBlend.Cost();

    }
}
