using System;

namespace Price_Calculator_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Tax T = new Tax("The Little Prince", 12345, 20.25, 21);
            string result = T.PriceWithTax();
            System.Console.WriteLine(result);

        }
    }
}
