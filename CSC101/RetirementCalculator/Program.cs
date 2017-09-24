using System;

namespace RetirementCalculator
{
    class Program
    {
        /// <summary> Calculate the number of years remaining until retirement age. </summary>
        static void Main(string[] args)
        {
            const int retirementAge = 65;

            int myAge = 23;
            int yourAge = 40;

            const string message = "How many years are left until our retirement?";
            Console.WriteLine(message);

            int yearsLeftForMe  = retirementAge - myAge;
            int yearsLeftForYou = retirementAge - yourAge;

            Console.WriteLine("Years left for me: " + yearsLeftForMe);
            Console.WriteLine("Years left for you: {0}", yearsLeftForYou);
        }
    }
}
