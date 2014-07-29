using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class Customer
    {

        public Customer()
        {

        }

        public Customer(int _customerId)
        {
            this.CustomerId = _customerId;
        }

        public static int InstanceCount { get; set; }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName{get;set;}

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string _fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(_fullName))
                    {
                        _fullName += ", ";
                    }
                    _fullName += FirstName;
                }
                return _fullName;
            }
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

            return isValid;
        }
                
    }
}
