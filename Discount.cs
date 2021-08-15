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

        public double TaxValue { get; private set; }
        private double setTaxValue
        {
            set { TaxValue = value; }
        }


        public Discount(string name, int UPC, double Price, double taxValue, double discount)
        {
            tax = new Tax(name, UPC, Price, taxValue);
            setTaxValue = taxValue;
            SetDiscountValue = discount;
            SetDiscountAmount = Price * (discount / 100);
            setFinalPrice = tax.PriceAfterTax(taxValue) - DiscountAmount;

        }

        public Discount(string name, int UPC, double Price, double taxAmount)
        {
            tax = new Tax(name, UPC, Price, taxAmount);

        }

        public string ProductInfo()
        {
            return tax.GetProductInfo();
        }

        public double TaxAmount()
        {
            return tax.flat_rate_tax_amount;
        }

        public double RealProductPrice()
        {
            return tax.RealPrice();
        }


        public string Report(bool Choose)
        {
            string PeoductInformation = ProductInfo();
            double taxAmount = TaxAmount();
            double RealPrice = RealProductPrice();


            if (Choose == true)
            {
                string TaxDiscountValues = $"Tax value = {tax.flat_rate_tax}%, Discount value = {DiscountValue}%";
                string TaxDiscountAmounts = $"Tax amount= {Math.Round(taxAmount, 2)}$, Discount amount = {DiscountAmount}$";
                string PriceSituation = $"Real Price = {RealPrice}$ , Price After unviersal Discount = {Math.Round(FinalPrice, 2)}$";

                return PeoductInformation + "\n" + TaxDiscountValues + "\n"
                + TaxDiscountAmounts + "\n" + PriceSituation;
            }
            else
            {
                string TaxDiscountValues = $"Tax value = {tax.flat_rate_tax}%, No Discount";
                string TaxDiscountAmounts = $"Tax amount= {Math.Round(taxAmount, 2)}$";
                string PriceSituation = $"Price before = {RealPrice}$ , Price After = {Math.Round(tax.FinalPrice, 2)}$";
                return PeoductInformation + "\n" + TaxDiscountValues + "\n"
                + TaxDiscountAmounts + "\n" + PriceSituation + "\n"
                + "Program doesn’t show any discounted amount. ";

            }
        }

    }
}

