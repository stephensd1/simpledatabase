using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleDatabase2.Models
{
    public class Bidder
    {
        [Key]
        public int Bidder_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Street_Name { get; set; }
        public string Street_Number { get; set; }
        public string Suite_Number { get; set; }
        public string Bidder_City { get; set; }
        public string Bidder_State { get; set; }
        public string Bidder_Zip { get; set; }
        public string Bidder_Email { get; set; }
        public string Join_Society { get; set; }
        public Bidder Refers { get; set; }
    }
}