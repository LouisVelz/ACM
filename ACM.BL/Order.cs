﻿using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
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

        public bool Validate()
        {
            bool isValid = true;
            if (!string.IsNullOrWhiteSpace(ShippingAddress)) isValid = false;
            if (OrderItems.Count == 0) isValid = false;
            if (Customer == null) isValid = false;

            return isValid;
        }

        public List<Order> Retrieve()
        {
            List<Order> list = new List<Order>();

            //write functionality to return all orders
            return list;
        }
        
        public Order Retrieve(int orderId)
        {
            //write functionality to return all orders
            return new Order();
        }

        public bool Save(Order order)
        {
            //write code to save order

            return true;
        }
    }
}
