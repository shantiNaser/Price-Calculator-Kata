using System;

namespace Price_Calculator_Kata
{
    public class Discount
    {
        Tax tax;
        public double DiscountValue { get; private set; }
        public double DiscountAmount { get; private set; }
        private double SetDiscountValue
        {
            set
            {
                DiscountValue = value;
            }
        }
        private double SetDiscountAmount
        {
            set
            {
                DiscountAmount = value;
            }
        }

        public double FinalPrice { get; private set; }
        private double setFinalPrice
        {
            set { FinalPrice = value; }
        }

        public Discount(string name, int UPC, double Price, double taxAmount, double discount)
        {
            tax = new Tax(name, UPC, Price, taxAmount);
            SetDiscountValue = discount;
            SetDiscountAmount = Price * (discount / 100);
            setFinalPrice = tax.PriceAfterTax(taxAmount) - DiscountAmount;
            string Result = Report(true);
            System.Console.WriteLine(Result);

        }

        public Discount(string name, int UPC, double Price, double taxAmount)
        {
            tax = new Tax(name, UPC, Price, taxAmount);
            string Result = Report(false);
            System.Console.WriteLine(Result);

        }


        public string Report(bool Choose)
        {
            string ProductInfo = tax.GetProductInfo();
            double taxAmount = tax.flat_rate_tax_amount;
            double RealPrice = tax.RealPrice();


            if (Choose == true)
            {
                string TaxDiscountValues = $"Tax value = {tax.flat_rate_tax}%, Discount value = {DiscountValue}%";
                string TaxDiscountAmounts = $"Tax amount= {Math.Round(taxAmount, 2)}$, Discount amount = {DiscountAmount}$";
                string PriceSituation = $"Real Price = {RealPrice}$ , Price After unviersal Discount = {Math.Round(FinalPrice, 2)}$";

                return ProductInfo + "\n" + TaxDiscountValues + "\n"
                + TaxDiscountAmounts + "\n" + PriceSituation;
            }
            else
            {
                string TaxDiscountValues = $"Tax value = {tax.flat_rate_tax}%, No Discount";
                string TaxDiscountAmounts = $"Tax amount= {Math.Round(taxAmount, 2)}$";
                string PriceSituation = $"Price before = {RealPrice}$ , Price After = {Math.Round(tax.FinalPrice, 2)}$";
                return ProductInfo + "\n" + TaxDiscountValues + "\n"
                + TaxDiscountAmounts + "\n" + PriceSituation + "\n"
                + "Program doesn’t show any discounted amount. ";

            }
        }

    }
}

