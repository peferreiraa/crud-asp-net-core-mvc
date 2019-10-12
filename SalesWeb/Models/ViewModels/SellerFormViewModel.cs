using System;
using System.Collections.Generic;


namespace SalesWeb.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}
