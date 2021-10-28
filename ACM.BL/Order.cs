using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order() : this(0)
        {
            
        }
        public Order(int orderId=1)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public int OrderId { get; private set; } 
        public Customer Customer { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int CustomerID { get; set; }
        public int ShippingAddressId { get; set; }

        public override bool Validate()
        {
            bool isValid = true;
            if (!string.IsNullOrWhiteSpace(ShippingAddress)) isValid = false;
            if (OrderItems.Count == 0) isValid = false;
            if (Customer == null) isValid = false;

            return isValid;
        }

        public string Log() => $"{OrderId}: Date {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";
    }
}
