using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACME.Common;

namespace ACME.BL
{
    public class Customer : EntityBase, ILoggable
    {

       public Customer()
            :this(0)
        {

        }

        public Customer(int _customerId)
        {
            this.CustomerId = _customerId;
            AddressList =  new List<Address>();
        }

        public static int InstanceCount { get; set; }

        public List<Address> AddressList { get; set; }

        public int CustomerType { get; set; }

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

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return FullName;
        }

        public string Log()
        {
            var _logString = this.CustomerId + ": " +
                             this.FullName + " " +
                             "Email: " + this.EmailAddress + " " + 
                              "Status " + this.EntityState.ToString();
            return _logString;
        }


        public void ValidateEmail()
        {
            throw new NotImplementedException();
        }

        public object CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            decimal goalStepCount = 0;
            decimal actualStepCount = 0;

            //possibly code smell
            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal Must be Entered", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Actual Steps Must be Entered", "actualSteps");

            if (!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException("Goal Must Be Numeric", "goalSteps");
            if (!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException("Actual Steps Must Be Numeric", "actualSteps");

            if (goalStepCount <= 0) throw new ArgumentException("Goal Must Be Greater Than 0", "goalSteps");

            decimal.TryParse(goalSteps, out goalStepCount);
            decimal.TryParse(actualSteps, out actualStepCount);

            return (Convert.ToDecimal(actualSteps) / Convert.ToDecimal(goalSteps)) * 100; ;
        }
    }
}
