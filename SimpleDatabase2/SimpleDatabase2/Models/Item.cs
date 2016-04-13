using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleDatabase2.Models
{
    public class Item
    {
        [Key]
        public int Item_Number { get; set; }
        public string Item_Name { get; set; }
        public Decimal Item_Value { get; set; }
        public string Item_Decription { get; set; }
        public Decimal Sold_Amount { get; set; }
        public string Item_Category { get; set; }
        public Donor Donor { get; set; }
        public Bidder Bidder { get; set; }
        public Payment Payment { get; set; }
        public Solicitor Solicitor { get; set; }
    }
}