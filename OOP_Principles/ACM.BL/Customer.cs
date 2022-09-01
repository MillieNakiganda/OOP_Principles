using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
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

        public List<Customer> Retrieve()
        {
            //retrieve all customers
            return new List<Customer>();
        }

        public Customer Retrieve(int customerId)
        {
            //retrieve defined customer
            return new Customer();
        }

        public bool Save()
        {
            //saves a customer
            return true;
        }
    }
}
