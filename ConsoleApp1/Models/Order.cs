﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }

        public Customer customer { get; set; }
        public ICollection<OrderProducts> OrderProducts { get; set; }

    }
}