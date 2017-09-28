using System;

namespace CSC102
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            int intAge = int.Parse(age);
            intAge += 1;

            string stringAge = intAge.ToString();

            Console.WriteLine("Next year you will be {0} years old.", stringAge);
        }
    }
}
