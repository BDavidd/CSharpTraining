using System;

namespace TipCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Tipper tipper = new Tipper();

            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Write("How much is the bill?");
                string billInput = Console.ReadLine();
                try
                {
                    tipper.BillAmount = double.Parse(billInput);
                }
                catch
                {
                    Console.WriteLine("Only numeric values are allowed");
                    continue;
                }

                Console.Write("B)ad tip O)k tip G)ood Tip D)ivvy the bill Q)uit: ");
                string selection = Console.ReadLine().ToUpper();

                switch (selection[0])
                {
                    case 'B':
                        Console.WriteLine("You should tip {0:C}.", tipper.CalculateTip(0.1));
                        break;

                    case 'O':
                        Console.WriteLine("You should tip {0:C}", tipper.CalculateTip());
                        break;

                    case 'G':
                        Console.WriteLine("You should tip {0:C}.", tipper.CalculateTip(0.2));
                        break;

                    case 'D':
                        Console.WriteLine("How many people are splitting the bill?");
                        string peopleNumber = Console.ReadLine();
                        try
                        {
                            Console.WriteLine("Each should pay {0:C}", tipper.Divvy(int.Parse(peopleNumber)));
                        }
                        catch
                        {
                            Console.WriteLine("Only numeric values are allowed!");
                        }
                        break;

                    case 'Q':
                        keepLooping = false;
                        break;

                    default:
                        Console.WriteLine("Only the letters B,O,G,D and Q are accepted as input.");
                        break;
                }
            }
        }
    }
}
