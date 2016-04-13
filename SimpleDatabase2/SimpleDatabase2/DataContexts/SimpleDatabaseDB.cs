using SimpleDatabase2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleDatabase2.DataContent
{
    public class SimpleDatabaseDB : DbContext
    {
         public SimpleDatabaseDB()
             :base("name=DefaultConnection")
          { 
          }

        public DbSet<Item> Item {get; set;}
        public DbSet<Donor> Donor {get; set;}
        public DbSet<Solicitor> Solicitor {get; set;}
        public DbSet<Role> Role {get; set;}
        public DbSet<Auction> Auction {get; set;}
        public DbSet<Bidder> Bidder {get; set;}
        public DbSet<Payment> Payment {get; set;}
        public DbSet<Role_Solicitor> Role_Solicitor { get; set; }
        public DbSet<Role_Donor> Role_Donor { get; set; }
        public DbSet<Role_Bidder> Role_Bidder { get; set; }
        public DbSet<Auction_Item> Auction_Item { get; set; }

        
    }
}