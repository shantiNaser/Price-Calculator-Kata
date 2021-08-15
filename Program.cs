using System;

namespace Price_Calculator_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tax ProductTax = new Tax("The Little Prince", 12345, 20.25, 21);

            // You Can Remove the Discount value and find the Information with No discount
            // Discount ProductDiscount = new Discount("The Little Prince", 12345, 20.25, 20, 15);

            // You Can Remove the UPC Discount value and find the Information with No UPCDiscount
            UPCDiscount upc = new UPCDiscount("The Little Prince", 12345, 20.25, 20, 15, 7);

        }
    }
}
