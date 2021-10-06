using System.Collections.Generic;

namespace ACM.BL.Persistence
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            //code that retrieves customer

            Customer customer = new Customer(1)
            {
                EmailAddress = "JohnSnow@email.me",
                FirstName = "John",
                LastName = "Snow"
            };

            if (customerId == 1) return customer;

            return new Customer(2);
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

            return new List<Customer>()
            {
                 new Customer(1),
                 new Customer(2),

            };
        }
    }
}
