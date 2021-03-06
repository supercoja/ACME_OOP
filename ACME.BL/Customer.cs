﻿using System;
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

        public OperationResult ValidateEmail()
        {
            var _op = new OperationResult();

            if (string.IsNullOrWhiteSpace(this.EmailAddress)) 
            {
                _op.Sucess = false;
                _op.AddMessage("Email Address Is Null");
            }

            if (_op.Sucess)
            {
             var _isValidFormat = true;
            if (!_isValidFormat) 
            {
                _op.Sucess = false;
                _op.AddMessage("Email Address is not in a correct Form");
            }
            }

            if (_op.Sucess)
            {
                var _isRealDomain = true;

            if (!_isRealDomain) 
            {
                _op.Sucess = false;
                _op.AddMessage("Email Address Does not Include a valid domain");
            }

            }
            return _op;
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal Must be Entered");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Actual Steps Must be Entered", "actualSteps");

            decimal goalStepCount = 0;
            if (!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException("Goal Must Be Numeric");

            decimal actualStepCount = 0;
            if (!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException("Actual Steps Must Be Numeric", "actualSteps");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal Must Be Greater Than 0", "goalSteps");
            return (actualStepCount / goalStepCount) * 100;
        }
    }
}
