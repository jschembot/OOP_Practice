using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Model
{
    public class Order : EntityBase
    {
        public Order() : this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public int CusomterId { get; set; }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public OrderItem OrderItem { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }
        public override string ToString() => OrderDate.ToString();
        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
