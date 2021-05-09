using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Model
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            // Code that retreives the defined customer;

            //Temp hard-coded values to return a populated customer
            if(customerId == 1)
            {
                customer.EmailAddress = "mememe@gmail.com";
                customer.FirstName = "jon";
                customer.LastName = "schemmel";
                customer.AddressList = addressRepository.RetrieveByCustomerId(1).ToList();
            }
            return customer;
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        public bool Save()
        {
            return true;
        }
    }
}
