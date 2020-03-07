using System;

namespace EmailTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Type value A and press <ENTER> to confirm: ");
                string valA = Console.ReadLine();
                Console.Write("Type value B and press <ENTER> to confirm: ");
                string valB = Console.ReadLine();
                Console.Write("Select operation and press <ENTER> to confirm: ");
                string operation = Console.ReadLine();

                double result = CalculationFactory.CreateCalculation(operation).GetValue(Double.Parse(valA), Double.Parse(valB));
                Console.WriteLine($"Operation value: {result}");
            }
            catch(Exception calculationException)
            {
                Console.WriteLine(calculationException.Message);
                Console.WriteLine(calculationException.StackTrace);
            }

            Console.ReadKey();
        }
    }
}
