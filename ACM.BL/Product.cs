﻿using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Product
    {
        public Product(Guid productId= new Guid())
        {
            ProductId = productId;
        }

        public Guid ProductId {
            get;
            private set;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double CurrentPrice { get; set; }

        public bool Validate()
        {
            bool isValid = !string.IsNullOrEmpty(Name);

            if (CurrentPrice == 0) isValid = false;

            return isValid;
        }

        public static List<Product> Retrieve()
        {
            //write code to retrieve all;

            return new List<Product>();
        }

        public static Product Retrieve(Guid productId)
        {
            //write code to retrieve using a Guid

            return new Product();
        }

        public bool Save(Product product)
        {
            //write code to save

            return true;
        }
    }
}