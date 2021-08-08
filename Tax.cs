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
        Product product;
        double FinalPrice;

        // Constructer .... 
        public Tax(string name, int UPC, double Price, double tax)
        {
            product = new Product(name, UPC, Price);
            setTax = tax;
            double Totall = Price + (Price * (tax / 100));
            FinalPrice = Totall;
        }

        // Query Should return a data , since it has no affect in the system ...
        public string PriceWithTax()
        {
            string ProductInfo = product.GetProductInformation();
            string Finall_Price = $"Product price reported as ${product.Price} before tax and ${Math.Round(FinalPrice, 2)} after {flat_rate_tax}% tax.";
            return ProductInfo + "\n" + Finall_Price;
        }




    }
}