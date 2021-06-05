using System;
using System.Collections.Generic;

namespace OfferConsole
{
    public class ProductFactory
    {
        private List<Product> productTypes;
        
        public ProductFactory()
        {
            productTypes = new List<Product>()
            {

            };
        }

        public static Product Create(string v)
        {
            throw new NotImplementedException();
        }
    }
}