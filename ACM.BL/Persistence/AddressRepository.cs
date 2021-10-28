using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Persistence
{
    public class AddressRepository
    {

        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag end";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shite";
                address.County = "Middle Earth";
                address.PostalCode = "11212";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>()
            {
                new Address(1)
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shite",
                    County = "Middle Earth",
                    PostalCode = "11212",
                },
                new Address(2)
                {
                    AddressType = 2,
                    StreetLine1 = "Green Dragon",
                    City = "Bywater",
                    State = "Shire",
                    County = "Middle Earth",
                    PostalCode = "11212",
                }
            };

            return addressList;
        }

        public bool Save(Address address)
        {
            //code to retrieve

            return true;
        }
    }
}
