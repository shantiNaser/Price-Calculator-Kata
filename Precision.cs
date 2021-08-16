using System;

namespace Price_Calculator_Kata
{
    public class Precision
    {
        UPCDiscount precision;

        public Precision(string name, int UPC, double Price, double Taxvalue,
        double Discount, double UPCDiscount, double TransportCoast)
        {
            precision = new UPCDiscount(name, UPC, Price, Taxvalue, Discount, UPCDiscount);
            double taxAmount = (Price * (Taxvalue / 100));
            double UnviersalDiscaount = (Price * (Discount / 100));
            double UPCdiscountAmount = ((Price - UnviersalDiscaount) * (UPCDiscount / 100));
            double TotallDiscount = UnviersalDiscaount + UPCdiscountAmount;
            double TransportCoastAmount = (Price * (TransportCoast / 100));
            string Result = Report(Price, taxAmount, TotallDiscount, TransportCoastAmount);
            System.Console.WriteLine(Result);

        }

        public string Report(double Price, double Tax, double AllDiscaount, double TransportCoastAmount)
        {
            return $"Cost = {Math.Round(Price, 2)}$" + "\n" +
                   $"Tax  = {Math.Round(Tax, 2)}$" + "\n" +
                   $"Discount = {Math.Round(AllDiscaount, 2)}$" + "\n" +
                   $"Transport = {Math.Round(TransportCoastAmount, 2)}" + "\n" +
                   $"Totall = {Math.Round((Price + Tax + TransportCoastAmount - AllDiscaount), 2)}";
        }
    }
}