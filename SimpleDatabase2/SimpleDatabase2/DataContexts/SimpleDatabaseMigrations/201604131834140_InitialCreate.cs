namespace SimpleDatabase2.DataContexts.SimpleDatabaseMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auctions",
                c => new
                    {
                        Auction_ID = c.Int(nullable: false, identity: true),
                        Auction_Name = c.String(),
                        Auction_Type = c.String(),
                        Auction_Date = c.DateTime(nullable: false),
                        Start_Time = c.Time(nullable: false, precision: 7),
                        Close_Time = c.Time(nullable: false, precision: 7),
                        Auction_Location = c.String(),
                    })
                .PrimaryKey(t => t.Auction_ID);
            
            CreateTable(
                "dbo.Auction_Item",
                c => new
                    {
                        Item_Number = c.Int(nullable: false),
                        Auction_Id = c.Int(nullable: false),
                        Start_Bid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Increment = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.Item_Number, t.Auction_Id })
                .ForeignKey("dbo.Auctions", t => t.Auction_Id, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.Item_Number, cascadeDelete: true)
                .Index(t => t.Item_Number)
                .Index(t => t.Auction_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Item_Number = c.Int(nullable: false, identity: true),
                        Item_Name = c.String(),
                        Item_Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Item_Decription = c.String(),
                        Sold_Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Item_Category = c.String(),
                        Bidder_Bidder_ID = c.Int(),
                        Donor_Donor_ID = c.Int(),
                        Payment_Payment_ID = c.Int(),
                        Solicitor_Solicitor_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Item_Number)
                .ForeignKey("dbo.Bidders", t => t.Bidder_Bidder_ID)
                .ForeignKey("dbo.Donors", t => t.Donor_Donor_ID)
                .ForeignKey("dbo.Payments", t => t.Payment_Payment_ID)
                .ForeignKey("dbo.Solicitors", t => t.Solicitor_Solicitor_ID)
                .Index(t => t.Bidder_Bidder_ID)
                .Index(t => t.Donor_Donor_ID)
                .Index(t => t.Payment_Payment_ID)
                .Index(t => t.Solicitor_Solicitor_ID);
            
            CreateTable(
                "dbo.Bidders",
                c => new
                    {
                        Bidder_ID = c.Int(nullable: false, identity: true),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Street_Name = c.String(),
                        Street_Number = c.String(),
                        Suite_Number = c.String(),
                        Bidder_City = c.String(),
                        Bidder_State = c.String(),
                        Bidder_Zip = c.String(),
                        Bidder_Email = c.String(),
                        Join_Society = c.String(),
                        Refers_Bidder_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Bidder_ID)
                .ForeignKey("dbo.Bidders", t => t.Refers_Bidder_ID)
                .Index(t => t.Refers_Bidder_ID);
            
            CreateTable(
                "dbo.Donors",
                c => new
                    {
                        Donor_ID = c.Int(nullable: false, identity: true),
                        Donor_Name = c.String(),
                        Donor_Email = c.String(),
                        Donor_Phone = c.String(),
                        Street_Name = c.String(),
                        Street_Number = c.String(),
                        Suite_Number = c.String(),
                        Donor_City = c.String(),
                        Donor_State = c.String(),
                        Donor_Zip = c.String(),
                    })
                .PrimaryKey(t => t.Donor_ID);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Payment_ID = c.Int(nullable: false, identity: true),
                        Payment_Type = c.String(),
                        Date = c.DateTime(nullable: false),
                        Bidder_Bidder_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Payment_ID)
                .ForeignKey("dbo.Bidders", t => t.Bidder_Bidder_ID)
                .Index(t => t.Bidder_Bidder_ID);
            
            CreateTable(
                "dbo.Solicitors",
                c => new
                    {
                        Solicitor_ID = c.Int(nullable: false, identity: true),
                        Solicitor_Name = c.String(),
                    })
                .PrimaryKey(t => t.Solicitor_ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Role_ID = c.Int(nullable: false, identity: true),
                        Role_Type = c.String(),
                        Role_Description = c.String(),
                    })
                .PrimaryKey(t => t.Role_ID);
            
            CreateTable(
                "dbo.Role_Bidder",
                c => new
                    {
                        Role_Id = c.Int(nullable: false),
                        Bidder_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.Bidder_Id })
                .ForeignKey("dbo.Bidders", t => t.Bidder_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.Bidder_Id);
            
            CreateTable(
                "dbo.Role_Donor",
                c => new
                    {
                        Role_Id = c.Int(nullable: false),
                        Donor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.Donor_Id })
                .ForeignKey("dbo.Donors", t => t.Donor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.Donor_Id);
            
            CreateTable(
                "dbo.Role_Solicitor",
                c => new
                    {
                        Role_Id = c.Int(nullable: false),
                        Solicitor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.Solicitor_Id })
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.Solicitors", t => t.Solicitor_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.Solicitor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Role_Solicitor", "Solicitor_Id", "dbo.Solicitors");
            DropForeignKey("dbo.Role_Solicitor", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Role_Donor", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Role_Donor", "Donor_Id", "dbo.Donors");
            DropForeignKey("dbo.Role_Bidder", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Role_Bidder", "Bidder_Id", "dbo.Bidders");
            DropForeignKey("dbo.Auction_Item", "Item_Number", "dbo.Items");
            DropForeignKey("dbo.Items", "Solicitor_Solicitor_ID", "dbo.Solicitors");
            DropForeignKey("dbo.Items", "Payment_Payment_ID", "dbo.Payments");
            DropForeignKey("dbo.Payments", "Bidder_Bidder_ID", "dbo.Bidders");
            DropForeignKey("dbo.Items", "Donor_Donor_ID", "dbo.Donors");
            DropForeignKey("dbo.Items", "Bidder_Bidder_ID", "dbo.Bidders");
            DropForeignKey("dbo.Bidders", "Refers_Bidder_ID", "dbo.Bidders");
            DropForeignKey("dbo.Auction_Item", "Auction_Id", "dbo.Auctions");
            DropIndex("dbo.Role_Solicitor", new[] { "Solicitor_Id" });
            DropIndex("dbo.Role_Solicitor", new[] { "Role_Id" });
            DropIndex("dbo.Role_Donor", new[] { "Donor_Id" });
            DropIndex("dbo.Role_Donor", new[] { "Role_Id" });
            DropIndex("dbo.Role_Bidder", new[] { "Bidder_Id" });
            DropIndex("dbo.Role_Bidder", new[] { "Role_Id" });
            DropIndex("dbo.Payments", new[] { "Bidder_Bidder_ID" });
            DropIndex("dbo.Bidders", new[] { "Refers_Bidder_ID" });
            DropIndex("dbo.Items", new[] { "Solicitor_Solicitor_ID" });
            DropIndex("dbo.Items", new[] { "Payment_Payment_ID" });
            DropIndex("dbo.Items", new[] { "Donor_Donor_ID" });
            DropIndex("dbo.Items", new[] { "Bidder_Bidder_ID" });
            DropIndex("dbo.Auction_Item", new[] { "Auction_Id" });
            DropIndex("dbo.Auction_Item", new[] { "Item_Number" });
            DropTable("dbo.Role_Solicitor");
            DropTable("dbo.Role_Donor");
            DropTable("dbo.Role_Bidder");
            DropTable("dbo.Roles");
            DropTable("dbo.Solicitors");
            DropTable("dbo.Payments");
            DropTable("dbo.Donors");
            DropTable("dbo.Bidders");
            DropTable("dbo.Items");
            DropTable("dbo.Auction_Item");
            DropTable("dbo.Auctions");
        }
    }
}
