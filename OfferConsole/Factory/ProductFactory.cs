using System;
using System.Collections.Generic;

namespace OfferConsole
{
    // Temp Fake Repo for Generating products
    public class ProductFactory
    {
        /// <summary>
        /// Singleton Instance of ProductFactory
        /// </summary>
        public static ProductFactory Instance = new ProductFactory();

        /// <summary>
        /// Dummy List of Product Label and its UnitPrice
        /// </summary>
        private Dictionary<string, int> productValues;
        
        /// <summary>
        /// Hidden Constructor
        /// </summary>
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

        /// <summary>
        /// Creates the Product specified by its Label
        /// </summary>
        public Product Create(string type)
        {
            if (!productValues.ContainsKey(type))
                throw new ArgumentOutOfRangeException("Unknown Product");

            return new Product(type, productValues[type]);
        }
    }
}