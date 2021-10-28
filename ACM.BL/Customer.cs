
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable

    {
    public Customer() : this(0)
    {
        //composition, a constructor calling the other constructor.
    }

    public Customer(int customerId)
    {
        CustomerId = customerId;
        AddressList = new List<Address>();
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

    public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

    public List<Address> AddressList { get; set; }
    public int CustomerType { get; set; }

    public static int InstanceCount { get; set; }

    public override bool Validate()
    {
        bool isValid = true;

        if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
        if (string.IsNullOrWhiteSpace(LastName)) isValid = false;

        return isValid;
    }

    }
}
