using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Model
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            // Code that retreives the defined customer;

            //Temp hard-coded values to return a populated customer
            if (productId == 1)
            {
                product.CurrentPrice = 12.34M;
                product.ProductDescription = "Smelly Cheese that has weird spots on it";
                product.ProductName = "Old Cheese";

            }
            return product;
        }
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Insert
                    }
                    else
                    {
                        // Update
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
