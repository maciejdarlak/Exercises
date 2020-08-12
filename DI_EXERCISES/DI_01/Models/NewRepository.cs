﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_01.Models
{
    public class NewRepository : IRepository
    {
        private Dictionary<string, Product> products;

        public NewRepository()
        {
            products = new Dictionary<string, Product>();

            new List<Product> {
                new Product { Name = "Women Shoes", Price = 99M },
                new Product { Name = "Skirts", Price = 29.99M },
                new Product { Name = "Pants", Price = 40.5M }
            }.ForEach(p => AddProduct(p));
        }

        public IEnumerable<Product> Products => products.Values;
        public Product this[string name] => products[name];
        public void AddProduct(Product product) => products[product.Name] = product; // products[product.Name] is a key but the value is fetched in parallel.
        public void DeleteProduct(Product product) => products.Remove(product.Name);
    }
}
