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

        public UPCDiscount(string name, int UPC, double Price, double taxAmount, double discount, double UPCDiscount)
        {
            universal_Discount = new Discount(name, UPC, Price, taxAmount, discount);
            SetUPCDiscountValue = UPCDiscount;
            SetUPCDiscountAmount = Price * (UPCDiscount / 100);
            setFinalPrice = (universal_Discount.FinalPrice) - UPCDiscountAmount;
            string result = Report();
            System.Console.WriteLine(result);
        }

        public UPCDiscount(string name, int UPC, double Price, double taxAmount, double discount)
        {
            universal_Discount = new Discount(name, UPC, Price, taxAmount, discount);
        }


        public string Report()
        {
            return $"UPC Discount value = {UPCDiscountValue}%, UPC Discount Amount = {Math.Round(UPCDiscountAmount, 2)}$" +
            "\n" + $"Final price after unverisal and UPC Discount is = {FinalPrice}$" + "\n" +
            $"All the Discount Amount is {Math.Round((universal_Discount.DiscountAmount + UPCDiscountAmount), 2) }$";
        }

    }
}