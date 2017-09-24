using System;

namespace Arithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double firstNumber;
            try
            {
                firstNumber = ReadNumber();
            }
            catch
            {
                return;
            }

            Console.Write("Enter the second number: ");
            double secondNumber;
            try
            {
                secondNumber = ReadNumber();
            }
            catch 
            {
                return;
            }

            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber);
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber);
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, firstNumber * secondNumber);
            if (secondNumber != 0)
            {
                Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, firstNumber / secondNumber);
            }
            else
            {
                Console.WriteLine("Error: denominator is zero.");
            }
        }

        private static double ReadNumber()
        {
            string input = Console.ReadLine();

            double number;
            try
            {
                number = double.Parse(input);
            }
            catch
            {
                Console.WriteLine("Only numbers are allowed as input.");
                throw;
            }

            return number;
        }
    }
}
