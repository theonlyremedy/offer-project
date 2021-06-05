namespace OfferConsole
{
    public class Product
    {
        public string Label { get; private set; }
        public int UnitPrice { get; private set; }
        public Product(string label, int unitPrice)
        {
            Label = label;
            UnitPrice = unitPrice;
        }
    }
}