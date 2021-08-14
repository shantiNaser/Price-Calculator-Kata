using System;
namespace Price_Calculator_Kata
{
    public class Tax
    {
        public double flat_rate_tax { get; private set; }
        private double setTax
        {
            set { flat_rate_tax = value; }
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
            setTax = tax;
            setTaxAmount = (product.Price * (tax / 100));
            setFinalPrice = PriceAfterTax(tax);
            string result = Report();
            System.Console.WriteLine(result);
        }

        public double PriceAfterTax(double tax)
        {
            return product.Price + (product.Price * (tax / 100));
        }


        // Query Should return a data , since it has no affect in the system ...
        public string Report()
        {
            string Finall_Price = $"Product price reported as ${RealPrice()} before tax and ${Math.Round(FinalPrice, 2)} after {flat_rate_tax}% tax.";
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