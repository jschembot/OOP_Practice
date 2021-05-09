using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Model
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            // Code that retreives the defined customer;

            //Temp hard-coded values to return a populated customer
            if (orderId == 1)
            {
                order.OrderDate = DateTime.Now;
            }
            return order;
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        public bool Save(Order order)
        {
            return true;
        }
    }
}
