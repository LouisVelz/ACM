﻿using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId
        {
            get;
            private set;
        }
        public string EmailAddress { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {

                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }

                return fullName;
            }
        }

        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        
        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;

            return isValid;
        }

    }
}
