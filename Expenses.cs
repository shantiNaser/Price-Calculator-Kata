using System;

namespace Price_Calculator_Kata
{
    public class Expenses
    {
        UPCDiscount Allcost;
        Tax OnlyTax;

        // when there's a Tax and Discount in the product
        public Expenses(string name, int UPC, double Price, double taxAmount,
        double discount, double UPCDiscount, double Packaging, double Transport)
        {
            Allcost = new UPCDiscount(name, UPC, Price, taxAmount, discount, UPCDiscount);
            double Taxvalue = (Price * (taxAmount / 100));
            double AllDiscaount = ((Price * (discount / 100)) + (Price * (UPCDiscount / 100)));
            double PackagingValue = (Price * (Packaging / 100));

            string Report = PrepareReportWithAdditionalCost(Price, Taxvalue, AllDiscaount, PackagingValue, Transport);
            System.Console.WriteLine(Report);
        }

        // when threre's no discounts and no additional costs.
        public Expenses(string name, int UPC, double Price, double tax)
        {
            OnlyTax = new Tax(name, UPC, Price, tax);
            double TaxAmount = (Price * (tax / 100));
            string Report = PrepareReportWithoutAdditionalCost(Price, TaxAmount);
            System.Console.WriteLine(Report);
        }

        public string PrepareReportWithAdditionalCost(double Price, double Tax, double AllDiscaount, double PackagingValue, double Transport)
        {
            return $"Cost = {Math.Round(Price, 2)}$" + "\n" +
                   $"Tax  = {Math.Round(Tax, 2)}$" + "\n" +
                   $"Discount = {Math.Round(AllDiscaount, 2)}$" + "\n" +
                   $"Packaging = {Math.Round(PackagingValue, 2)}$" + "\n" +
                   $"Transport = {Math.Round(Transport, 2)}$" + "\n" +
                   $"Totall = {Math.Round((Price + Tax - AllDiscaount + PackagingValue + Transport), 2)}";
        }

        public string PrepareReportWithoutAdditionalCost(double Price, double TaxingValue)
        {
            return $"Cost = {Math.Round(Price, 2)}$" + "\n" +
                   $"Tax  = {Math.Round(TaxingValue, 2)}$" + "\n" +
                   $"Totall = {Math.Round((Price + TaxingValue), 2)}";
        }



    }
}