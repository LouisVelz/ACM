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
                Name = "Product",
                Description = "Vans shoes",
                CurrentPrice = 9.99
            };

            return productId == 1 ? product : new Product(2);
        }

        public bool Save(Product product)
        {
            //write code to save

            return true;
        }
    }
}
