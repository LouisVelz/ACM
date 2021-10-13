using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Persistence
{
    class AddressRepository
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
    }
}
