using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {

        public Customer(Guid customerId = new Guid())
        {
            CustomerId = customerId;
        }

        public Guid CustomerId
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

        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;

            return isValid;
        }

        public Customer Retrieve(int customerId)
        {
            //code that retrieves customer

            return new Customer();
        }

        public bool Save(Customer customer)
        {
            //code that saves customer

            return true;
        }

        //this method is overloading
        //meaning it is the same as the retrieve but they will be called according
        //to the parameters passed when they are called.
        public List<Customer> Retrieve()
        {
            //code that retrieves all customers

            return new List<Customer>();
        }
    }
}
