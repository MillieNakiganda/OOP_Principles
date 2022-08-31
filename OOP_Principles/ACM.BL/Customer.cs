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
                return $"{LastName} , {FirstName}";
            }

        }
    }
}
