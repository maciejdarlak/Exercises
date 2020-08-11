﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_01.Models
{
    public class ProductSum
    {
        public IRepository Repository { get; set; }
        public ProductSum(IRepository repo)
        {
            Repository = repo;
        }

        public decimal Total => Repository.Products.Sum(p => p.Price);
    }
}
