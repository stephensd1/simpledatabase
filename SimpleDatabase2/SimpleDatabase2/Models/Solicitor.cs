using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleDatabase2.Models
{
    public class Solicitor
    {
        [Key]
        public int Solicitor_ID { get; set; }
        public string Solicitor_Name { get; set; }
    }
}