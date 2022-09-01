using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer(int customerId)
        {
            //since customerId has a private setter, we need to create it through the constructor
            CustomerId = customerId;
            //we initialize the address list property because it is not like other types, it will not be assigned a default value
            AddressList = new List<Address>();
        }

        public Customer()
        {
            //since we have added the constructor above, best we set this one for other properties
        }
        //1:n relationship, one customer can have several addresses
        public List<Address> AddressList { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        private string _lastname;
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }
        public string FullName
        {
            get
            {
                string fullname = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname = ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }

        }

        public bool validate()
        {
            //validates customer data
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
        
    }
}
