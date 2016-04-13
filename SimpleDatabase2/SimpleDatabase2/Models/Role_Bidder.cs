using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SimpleDatabase2.Models
{
    public class Role_Bidder
    {
        [Key]
        [ForeignKey("Role")]
        [Column(Order = 1)]
        public int Role_Id { get; set; }
        public virtual Role Role { get; set; }

        [Key]
        [ForeignKey("Bidder")]
        [Column(Order = 2)]
        public int Bidder_Id { get; set; }
        public virtual Bidder Bidder { get; set; }
    }
}