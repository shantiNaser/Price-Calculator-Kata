using System;

namespace Price_Calculator_Kata
{
    public class Cap
    {
        UPCDiscount cap;


        public Cap(string name, int UPC, double Price, double Taxvalue,
        double Discount, double UPCDiscount, double capValue)
        {
            cap = new UPCDiscount(name, UPC, Price, Taxvalue, Discount, UPCDiscount);
            double TaxAmount = (Price * (Taxvalue / 100));
            double AllDiscaount = ((Price * (Discount / 100)) + (Price * (UPCDiscount / 100)));
            double capAmount = (Price * (capValue / 100));
            if (capValue < AllDiscaount)
            {
                string Result = Report(Price, TaxAmount, capValue);
                System.Console.WriteLine(Result);
            }
            else if (capAmount < AllDiscaount)
            {
                string Result = Report(Price, TaxAmount, capAmount);
                System.Console.WriteLine(Result);
            }
            else
            {
                string Result = Report(Price, TaxAmount, AllDiscaount);
                System.Console.WriteLine(Result);
            }

        }

        public string Report(double Price, double Tax, double AllDiscaount)
        {
            return $"Cost = {Math.Round(Price, 2)}$" + "\n" +
                   $"Tax  = {Math.Round(Tax, 2)}$" + "\n" +
                   $"Discount = {Math.Round(AllDiscaount, 2)}$" + "\n" +
                   $"Totall = {Math.Round((Price + Tax - AllDiscaount), 2)}";
        }
    }
}