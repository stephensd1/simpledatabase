using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleDatabase2.Models
{
    public class Payment
    {
        [Key]
        public int Payment_ID { get; set; }
        public string Payment_Type { get; set; }
        public DateTime Date { get; set; }
        public Bidder Bidder { get; set; }
    }
}