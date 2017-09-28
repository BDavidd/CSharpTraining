using System;

namespace BillCalculator
{
    class Program
    {
        /// <summary> Computes the values usually displayed on a bill. </summary>
        public static void Main(string[] args)
        {
            const double SodaPrice     = 1.50;
            const double SandwichPrice = 4.50;
            const double ChipsPrice    = 1.25;
            const double TaxRate       = 0.08;
            const double TipRate       = 0.15;

            int sodaNumber     = 2;
            int sandwichNumber = 2;
            int chipsNumber    = 1;

            double subtotal = sodaNumber * SodaPrice + sandwichNumber * SandwichPrice + chipsNumber * ChipsPrice;
            double tax = subtotal * TaxRate;
            double tip = subtotal * TipRate;
            double total = subtotal + tax + tip;

            Console.WriteLine("Subtotal {0:C}", subtotal);
            Console.WriteLine("Tax      {0:c}", tax);
            Console.WriteLine("Tip      {0:C}", tip);
            Console.WriteLine("TOTAL    {0:C}", total);
        }
    }
}
