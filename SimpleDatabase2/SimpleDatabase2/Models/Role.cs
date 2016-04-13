using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleDatabase2.Models
{
    public class Role
    {
        [Key]
        public int Role_ID { get; set; }
        public string Role_Type { get; set; }
        public string Role_Description { get; set; }
    }
}