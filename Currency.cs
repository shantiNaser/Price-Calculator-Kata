using System;

namespace Price_Calculator_Kata
{
    public class Currency
    {
        Discount withDiscount;
        Tax withoutDiscount;
        UPCDiscount withExtraDiscount;

        // unviersal Discount ....
        public Currency(string name, int UPC, double Price, double Taxvalue, double discount, string currency)
        {
            withDiscount = new Discount(name, UPC, Price, Taxvalue, discount);
            double taxAmount = (Price * (Taxvalue / 100));
            double discountamount = (Price * (discount / 100));
            string Result = Report(Price, taxAmount, discountamount, currency);
            System.Console.WriteLine(Result);
        }

        // No Discount ....
        public Currency(string name, int UPC, double Price, double Taxvalue, string currency)
        {
            withoutDiscount = new Tax(name, UPC, Price, Taxvalue);
            double taxAmount = (Price * (Taxvalue / 100));
            double AllDiscaount = 0;
            string Result = Report(Price, taxAmount, AllDiscaount, currency);
            System.Console.WriteLine(Result);
        }

        public Currency(string name, int UPC, double Price, double Taxvalue,
        double Discount, double UPCDiscount, string currency)
        {
            withExtraDiscount = new UPCDiscount(name, UPC, Price, Taxvalue, Discount, UPCDiscount);
            double taxAmount = (Price * (Taxvalue / 100));
            double discountamount = (Price * (Discount / 100)) + (Price * (UPCDiscount / 100));
            string Result = Report(Price, taxAmount, discountamount, currency);
            System.Console.WriteLine(Result);
        }


        public string Report(double Price, double Tax, double AllDiscaount, string currency)
        {
            string IsThereDiscount;
            if (AllDiscaount == 0)
                IsThereDiscount = "No Discount ...";
            else
                IsThereDiscount = $"All Discount = {Math.Round(AllDiscaount, 2)} {currency}";

            return $"Cost = {Math.Round(Price, 2)} {currency} " + "\n" +
                   $"Tax  = {Math.Round(Tax, 2)} {currency} " + "\n" +
                   $"{IsThereDiscount}" + "\n" +
                   $"Totall = {Math.Round((Price + Tax - AllDiscaount), 2)} {currency}";
        }
    }
}