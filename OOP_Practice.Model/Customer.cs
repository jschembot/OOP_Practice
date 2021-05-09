using System;
using System.Collections.Generic;

namespace OOP_Practice.Model
{
    public class Customer
    {
        public Customer() : this(0)
        {
          
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            // Below is a collarabition relationship
            AddressList = new List<Address>();
        }
        //Instead of doing:
        //  public Address HomeAddress
        //  public Address ShippingAddress
        // We can just make a list of addresses. 
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName 
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; }
        public override string ToString() => FullName;
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

    }
}
