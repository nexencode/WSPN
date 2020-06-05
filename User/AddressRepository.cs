using System;
using System.Collections.Generic;
using System.Text;

namespace WSP.BL
{
    class AddressRepository
    {
        public Address RetriveAddress(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.City = "Nis";
                address.Street = "Zaplanjska 18";
                address.PostalCode = "18110";
            }

            return address;
        }
    }
}
