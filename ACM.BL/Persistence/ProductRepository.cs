using System;
using System.Collections.Generic;

namespace ACM.BL.Persistence
{
    public class ProductRepository
    {
        public List<Product> Retrieve()
        {
            //write code to retrieve all;

            return new List<Product>();
        }

        public Product Retrieve(int productId)
        {
            //write code to retrieve using a Guid
            var product = new Product(1)
            {
                ProductName = "Product",
                ProductDescription = "Vans shoes",
                CurrentPrice = 9.99
            };
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return productId == 1 ? product : new Product(2);
        }

        public bool Save(Product product)
        {
            //write code to save

            return true;
        }
    }
}
