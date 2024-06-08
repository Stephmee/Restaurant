﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
   

    abstract public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        
        public MenuItem(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}-{Description}-{Price}$";
        }
    }
}
