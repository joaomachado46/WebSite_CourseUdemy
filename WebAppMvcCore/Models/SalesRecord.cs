﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcCore.Models.Enums;

namespace WebAppMvcCore.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount  { get; set; }
        public SalesStatus Status { get; set; }

        public int SellerId { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(DateTime date, double amount, SalesStatus status, Seller sellerId)
        {
            Date = date;
            Amount = amount;
            Status = status;
            Seller = sellerId;
        }
    }
}
