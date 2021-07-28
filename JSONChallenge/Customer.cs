using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    public class Customer
    {
        public Customer CustomerInfo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public Customer()
        {

        }

        public Customer(string firstName, string lastName, string phoneNumber, string shippingAddress, Customer customerInfo)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            CustomerInfo = customerInfo;
        }
    }
}
