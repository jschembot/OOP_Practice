using System.Collections.Generic;

namespace OOP_Practice.Model
{
    public class OrderItem
    {
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        public OrderItem Retrieve(int OrderItemId)
        {
            return new OrderItem();
        }
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;
            if (Quantity < 0) isValid = false;
            if (ProductId < 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }
    }
}