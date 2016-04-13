using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleDatabase2.Models
{
    public class Donor
    {
        [Key]
        public int Donor_ID { get; set; }
        public string Donor_Name {get; set;}
        public string Donor_Email { get; set; }
        public string Donor_Phone { get; set; }
        public string Street_Name { get; set; }
        public string Street_Number { get; set; }
        public string Suite_Number { get; set; }
        public string Donor_City { get; set; }
        public string Donor_State { get; set; }
        public string Donor_Zip { get; set; }
    }
}