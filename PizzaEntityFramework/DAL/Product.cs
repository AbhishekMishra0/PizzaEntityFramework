﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEntityFramework.DAL
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public string ProdType { get; set; }
    }
}
