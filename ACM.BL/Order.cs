using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public Order(int orderId=1)
        {
            OrderId = orderId;
        }
        public int OrderId { get; private set; } 
        public Customer Customer { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public bool Validate()
        {
            bool isValid = true;
            if (!string.IsNullOrWhiteSpace(ShippingAddress)) isValid = false;
            if (OrderItems.Count == 0) isValid = false;
            if (Customer == null) isValid = false;

            return isValid;
        }

    }
}
