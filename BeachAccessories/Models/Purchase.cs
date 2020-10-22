using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeachAccessories.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int? ProductId { get; set; }
        public string ProductCategory { get; set; }
        public decimal? ProductPrice { get; set; }
        public DateTime Date { get; set; }
        public string ProductName { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public int? NewPostNumber { get; set; }
        public string Comment { get; set; }
    }
}