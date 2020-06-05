using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace WSP.BL
{
    public class Address
    {
        #region Fields and Properties
        public int AddressId { get; set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        //Promeni u tip podatka Country kada napravis klasu
        public Country Country { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        #endregion

        #region Constructors
        public Address(int addressId)
        {
            AddressId = addressId;
        }
        #endregion

        #region Methods
        public bool Validate()
        {
            bool isValid = true;

            // method logic

            //

            return isValid;
        }
        public string ShowAddress()
        {
            return $"City: {City}, Street: {Street}, Postal Code: {PostalCode}";
        }
        #endregion
    }
}
