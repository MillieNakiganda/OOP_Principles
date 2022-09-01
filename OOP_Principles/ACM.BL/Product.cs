﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product(int productId)
        {
            //since productId has a private setter, we need to create it through the constructor
            ProductId = productId;
        }

        public Product()
        {
            //since we have added the constructor above, best we set this one for other properties
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public List<Product> Retrieve()
        {
            //retrieve all products
            return new List<Product>();
        }

        public Product Retrieve(int customerId)
        {
            //retrieve defined product
            return new Product();
        }

        public bool Save()
        {
            //saves a product
            return true;
        }
        public bool validate()
        {
            //validates customer data
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}