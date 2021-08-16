using System;

namespace Price_Calculator_Kata
{
    public class Combining
    {
        Expenses case1;
        UPCDiscount case2;

        public Combining(string name, int UPC, double Price, double Taxvalue,
        double Discount, double UPCDiscount, double PackagingValue, double Transport, int Choice)
        {
            if (Choice == 1)
            {
                case1 = new Expenses(name, UPC, Price, Taxvalue,
                            Discount, UPCDiscount, PackagingValue, Transport);
            }
            else if (Choice == 2)
            {
                case2 = new UPCDiscount(name, UPC, Price, Taxvalue, Discount, UPCDiscount);
                double taxAmount = (Price * (Taxvalue / 100));
                double discount1 = ((Price * (Discount / 100)));
                double discount2 = (Price - discount1) * (UPCDiscount / 100);
                double NewDiscount = discount1 + discount2;
                double PackagingAmount = (Price * (PackagingValue / 100));
                string Report = PrepareReportWithAdditionalCostCase2(Price, taxAmount, NewDiscount, PackagingAmount, Transport);
                System.Console.WriteLine(Report);

            }

        }


        public string PrepareReportWithAdditionalCostCase2(double Price, double Tax, double NewDiscount, double PackagingValue, double Transport)
        {
            return $"Cost = {Math.Round(Price, 2)}$" + "\n" +
                   $"Tax  = {Math.Round(Tax, 2)}$" + "\n" +
                   $"Discount = {Math.Round(NewDiscount, 2)}$" + "\n" +
                   $"Packaging = {Math.Round(PackagingValue, 2)}$" + "\n" +
                   $"Transport = {Math.Round(Transport, 2)}$" + "\n" +
                   $"Totall = {Math.Round((Price + Tax - NewDiscount + PackagingValue + Transport), 2)}";
        }

    }
}