using System;

namespace Price_Calculator_Kata
{
    public class Precision
    {
        UPCDiscount precision;

        public Precision(string name, int UPC, double Price, double Taxvalue,
        double Discount, double UPCDiscount, double TransportCoast, string Currency)
        {
            precision = new UPCDiscount(name, UPC, Price, Taxvalue, Discount, UPCDiscount);
            double taxAmount = (Price * (Taxvalue / 100));
            double UnviersalDiscaount = (Price * (Discount / 100));
            double UPCdiscountAmount = ((Price - UnviersalDiscaount) * (UPCDiscount / 100));
            double TotallDiscount = UnviersalDiscaount + UPCdiscountAmount;
            double TransportCoastAmount = (Price * (TransportCoast / 100));
            string Result = Report(Price, taxAmount, TotallDiscount, TransportCoastAmount, Currency);
            System.Console.WriteLine(Result);

        }

        public string Report(double Price, double Tax, double AllDiscaount, double TransportCoastAmount, string Currency)
        {
            return $"Cost = {Math.Round(Price, 2)} {Currency}" + "\n" +
                   $"Tax  = {Math.Round(Tax, 2)}{Currency}" + "\n" +
                   $"Discount = {Math.Round(AllDiscaount, 2)} {Currency}" + "\n" +
                   $"Transport = {Math.Round(TransportCoastAmount, 2)} {Currency}" + "\n" +
                   $"Totall = {Math.Round((Price + Tax + TransportCoastAmount - AllDiscaount), 2)} {Currency}";
        }
    }
}