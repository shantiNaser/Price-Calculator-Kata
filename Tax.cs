using System;
namespace Price_Calculator_Kata
{
    public class Tax
    {
        public double flat_rate_tax_Value { get; private set; }
        private double setTaxValue
        {
            set { flat_rate_tax_Value = value; }
        }

        public double flat_rate_tax_amount { get; private set; }
        private double setTaxAmount
        {
            set { flat_rate_tax_amount = value; }
        }


        Product product;

        public double FinalPrice { get; private set; }
        private double setFinalPrice
        {
            set { FinalPrice = value; }
        }

        // Constructer....
        public Tax(string name, int UPC, double Price, double tax)
        {
            product = new Product(name, UPC, Price);
            setTaxValue = tax;
            setTaxAmount = (Price * (tax / 100));
            setFinalPrice = Price + flat_rate_tax_amount;
        }


        // Query Should return a data , since it has no affect in the system ...
        public string Report()
        {
            string Finall_Price = $"Product price reported as ${RealPrice()} before tax and ${Math.Round(FinalPrice, 2)} after {flat_rate_tax_Value}% tax.";
            return GetProductInfo() + "\n" + Finall_Price;
        }

        public string GetProductInfo()
        {
            return product.GetProductInformation();
        }

        public double RealPrice()
        {
            return product.Price;
        }





    }
}