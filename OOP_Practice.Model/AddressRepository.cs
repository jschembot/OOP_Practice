using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Model
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            // Code that retreives the defined customer;

            //Temp hard-coded values to return a populated customer
            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Acorn Lane";
                address.StreetLine2 = "Royal Glen Dr";
                address.City = "Shiresville";
                address.StateProvince = "IL";
                address.Country = "US";
                address.PostalCode = "60156";
            }
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Acorn Lane",
                StreetLine2 = "Royal Glen Dr",
                City = "Shiresville",
                StateProvince = "IL",
                Country = "US",
                PostalCode = "60156"
            };
            Address address2 = new Address(2)
            {
                AddressType = 1,
                StreetLine1 = "Ray Lane",
                StreetLine2 = "Ky Low Dr",
                City = "Star",
                StateProvince = "WA",
                Country = "RS",
                PostalCode = "12345"
            };
            addressList.Add(address);
            addressList.Add(address2);
            return addressList;
        }

        
        public List<Address> Retrieve()
        {
            return new List<Address>();
        }
        public bool Save()
        {
            return true;
        }
    }
}
