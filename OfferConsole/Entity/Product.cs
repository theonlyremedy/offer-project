namespace OfferConsole
{
    public class Product
    {
        #region Prop
        /// <summary>
        /// Product Label
        /// </summary>
        public string Label { get; private set; }

        /// <summary>
        /// Price of Single Unit of Product
        /// </summary>
        public int UnitPrice { get; private set; }
        #endregion

        #region Ctor
        public Product(string label, int unitPrice)
        {
            Label = label;
            UnitPrice = unitPrice;
        }
        #endregion
    }
}