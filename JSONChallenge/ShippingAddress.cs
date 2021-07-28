using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    public class ShippingAddress
    {
        public ShippingAddress Address { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        public ShippingAddress()
        {

        }

        public ShippingAddress(ShippingAddress address, string address1, string address2, string city, string state, int zip)
        {
            Address = address;
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zip;
        }
    }
}
