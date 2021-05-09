using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Model
{
    public class Product : EntityBase
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        // Overriding Base class functions
        public override string ToString() => ProductName;
        public override bool Validate()
        {
            var isValid = true;
            if (!string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (!string.IsNullOrWhiteSpace(ProductDescription)) isValid = false;
            if (CurrentPrice.HasValue) isValid = false;
            return isValid;
        }
        
    }
}
