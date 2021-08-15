using System;

namespace Price_Calculator_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----> Tax ProductTax = new Tax("The Little Prince", 12345, 20.25, 21);
            // System.Console.WriteLine(ProductTax.Report());
            // ----------------------------------------------------------------------------------

            // ----> You Can Remove the Discount value and find the Information with No discount
            // ----> by call Report method with false ....
            // Discount ProductDiscount = new Discount("The Little Prince", 12345, 20.25, 20, 15);
            // System.Console.WriteLine(ProductDiscount.Report(true));
            // ----------------------------------------------------------------------------------


            // ----> You Can Remove the UPC Discount value and find the Information with No UPCDiscount
            // UPCDiscount upc = new UPCDiscount("The Little Prince", 12345, 20.25, 20, 15, 7);
            // System.Console.WriteLine(upc.PrecedenceReport());
            // ----------------------------------------------------------------------------------

            Expenses E = new Expenses("The Little Prince", 12345, 20.25, 21, 15, 7, 1, 2.2);
        }
    }
}
