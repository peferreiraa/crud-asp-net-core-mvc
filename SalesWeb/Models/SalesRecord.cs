﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using SalesWeb.Models.Enums;
namespace SalesWeb.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }

      
        public Seller Seller { get; set; }

        [Display(Name = "Seller Confirmation")]
        public int SellerId { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

    }
}
