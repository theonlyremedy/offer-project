using System;
using System.Collections.Generic;

namespace OfferConsole
{
    // Temp Fake Repo for Generating products
    public class ProductFactory
    {
        public static ProductFactory Instance = new ProductFactory();
        private Dictionary<string, int> productValues;
        
        private ProductFactory()
        {
            productValues = new Dictionary<string, int>()
            {
                { "A", 50 },
                { "B", 30 },
                { "C", 20 },
                { "D", 15 }
            };
        }

        public Product Create(string type)
        {
            if (!productValues.ContainsKey(type))
                throw new ArgumentOutOfRangeException("Unknown Product");

            return new Product(type, productValues[type]);
        }
    }
}