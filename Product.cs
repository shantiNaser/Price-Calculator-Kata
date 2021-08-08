namespace Price_Calculator_Kata
{
    public class Product
    {
        public string Name { get; private set; }
        public int UPC { get; private set; }
        public double Price { get; private set; }


        // Constructer
        public Product(string name, int UPC, double Price)
        {
            this.Name = name;
            this.UPC = UPC;
            this.Price = Price;
        }

        public string GetProductInformation()
        {
            return $"Product Name \"{Name}\", UPC = {UPC} , Price = ${Price}";
        }

    }
}