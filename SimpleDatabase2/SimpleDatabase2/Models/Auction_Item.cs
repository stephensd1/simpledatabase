using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SimpleDatabase2.Models
{
    public class Auction_Item
    {
        [Key]
        [ForeignKey("Item")]
        [Column(Order = 1)]
        public int Item_Number { get; set; }
        public virtual Item Item { get; set; }

        [Key]
        [ForeignKey("Auction")]
        [Column(Order = 2)]
        public int Auction_Id { get; set; }
        public virtual Auction Auction { get; set; }

        public Decimal  Start_Bid { get; set; }
        public Decimal  Increment { get; set; }
    }
}