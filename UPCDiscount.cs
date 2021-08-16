using System;

namespace Price_Calculator_Kata
{
    public class UPCDiscount
    {
        Discount universal_Discount;

        public double UPCDiscountValue { get; private set; }
        public double UPCDiscountAmount { get; private set; }
        private double SetUPCDiscountValue
        {
            set
            {
                UPCDiscountValue = value;
            }
        }
        private double SetUPCDiscountAmount
        {
            set
            {
                UPCDiscountAmount = value;
            }
        }

        public double FinalPrice { get; private set; }
        private double setFinalPrice
        {
            set { FinalPrice = value; }
        }

        public int UPCValues { get; private set; }
        private int setUPCValue
        {
            set { UPCValues = value; }
        }

        public string GetProductInfo()
        {
            return universal_Discount.ProductInfo();
        }



        public UPCDiscount(string name, int UPC, double Price, double taxAmount, double discount, double UPCDiscount)
        {
            universal_Discount = new Discount(name, UPC, Price, taxAmount, discount);
            setUPCValue = UPC;
            SetUPCDiscountValue = UPCDiscount;
            SetUPCDiscountAmount = Price * (UPCDiscount / 100);
            setFinalPrice = (universal_Discount.FinalPrice) - UPCDiscountAmount;
        }

        public UPCDiscount(string name, int UPC, double Price, double taxAmount, double discount)
        {
            universal_Discount = new Discount(name, UPC, Price, taxAmount, discount);
        }



        public string SelectiveReport()
        {
            string ProductInfo = universal_Discount.ProductInfo();
            double TaxAmount = universal_Discount.TaxAmount();
            double TaxValue = universal_Discount.TaxValue;
            double DiscountAmount = universal_Discount.DiscountAmount;
            double DiscountValue = universal_Discount.DiscountValue;

            return ProductInfo + "\n" +
            $"Tax value = {TaxValue}%, Discount value = {DiscountValue}%" + "\n" +
            $"Tax amount= {Math.Round(TaxAmount, 2)}$, Discount amount = {DiscountAmount}$" +
            "\n" + $"UPC Discount value = {UPCDiscountValue}%, UPC Discount Amount = {Math.Round(UPCDiscountAmount, 2)}$" +
            "\n" + $"Real Price before anyThing is {universal_Discount.RealProductPrice()}Final price after unverisal and UPC Discount is = {FinalPrice}$" + "\n" +
            $"All the Discount Amount is {Math.Round((universal_Discount.DiscountAmount + UPCDiscountAmount), 2) }$";
        }

        public string PrecedenceReport()
        {
            string ProductInfo = universal_Discount.ProductInfo();
            double TaxAmount = universal_Discount.TaxAmount();
            double TaxValue = universal_Discount.TaxValue;
            double DiscountAmount = universal_Discount.DiscountAmount;
            double DiscountValue = universal_Discount.DiscountValue;
            double FinalPrice = universal_Discount.RealProductPrice() - UPCDiscountAmount;
            double RealPrice = universal_Discount.RealProductPrice();

            return ProductInfo + "\n" +
            $"Tax value = {TaxValue}%, universal discount (after tax)  = {DiscountValue}% ,UPC-discount (before tax)= {UPCDiscountValue}% for {UPCValues}" + "\n"
            + $"UPC Discount Amount = {Math.Round(UPCDiscountAmount, 2)}$" + "\n" + $"remaining price = {FinalPrice} $" + "\n"
            + $"Tax amount = {FinalPrice * (TaxValue / 100)}$ ,  universal discount = {FinalPrice * (DiscountValue / 100)}" + "\n"
            + $"Final Price = {Math.Round((RealPrice) - (Math.Round(UPCDiscountAmount, 2)) + (FinalPrice * (TaxValue / 100)) - (FinalPrice * (DiscountValue / 100)), 2)}$";






        }


    }
}