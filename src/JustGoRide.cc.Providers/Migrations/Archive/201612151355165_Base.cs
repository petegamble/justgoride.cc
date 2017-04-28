namespace JustGoRide.cc.Providers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Base : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(),
                        EmailAddress = c.String(),
                        Source = c.String(),
                        SourceUserId = c.String(),
                        JoinedOn = c.DateTime(nullable: false),
                        Forename = c.String(),
                        Surname = c.String(),
                        Title = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Address_AddressLine1 = c.String(),
                        Address_AddressLine2 = c.String(),
                        Address_City = c.String(),
                        Address_County = c.String(),
                        Address_Country = c.String(),
                        Address_PostCode = c.String(),
                        HomePhone = c.String(),
                        MobilePhone = c.String(),
                        EmergencyContactName = c.String(),
                        EmergencyContactNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        ImageUrl = c.String(),
                        Status = c.Int(nullable: false),
                        IsDropRide = c.Boolean(nullable: false),
                        GuardsRequired = c.Boolean(nullable: false),
                        Owner_Id = c.Guid(nullable: false),
                        Route_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.Owner_Id, cascadeDelete: true)
                .ForeignKey("dbo.Routes", t => t.Route_Id)
                .Index(t => t.Owner_Id)
                .Index(t => t.Route_Id);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        DistanceKm = c.Double(nullable: false),
                        ClimbM = c.Double(nullable: false),
                        ImageUrl = c.String(),
                        Private = c.Boolean(nullable: false),
                        Owner_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.Owner_Id, cascadeDelete: true)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.MemberClubs",
                c => new
                    {
                        Member_Id = c.Guid(nullable: false),
                        Club_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Member_Id, t.Club_Id })
                .ForeignKey("dbo.Members", t => t.Member_Id)
                .ForeignKey("dbo.Clubs", t => t.Club_Id)
                .Index(t => t.Member_Id)
                .Index(t => t.Club_Id);
            
            CreateTable(
                "dbo.EventMembers",
                c => new
                    {
                        Event_Id = c.Guid(nullable: false),
                        Member_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Event_Id, t.Member_Id })
                .ForeignKey("dbo.Events", t => t.Event_Id)
                .ForeignKey("dbo.Members", t => t.Member_Id)
                .Index(t => t.Event_Id)
                .Index(t => t.Member_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Routes", "Owner_Id", "dbo.Members");
            DropForeignKey("dbo.Events", "Route_Id", "dbo.Routes");
            DropForeignKey("dbo.EventMembers", "Member_Id", "dbo.Members");
            DropForeignKey("dbo.EventMembers", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.Events", "Owner_Id", "dbo.Members");
            DropForeignKey("dbo.MemberClubs", "Club_Id", "dbo.Clubs");
            DropForeignKey("dbo.MemberClubs", "Member_Id", "dbo.Members");
            DropIndex("dbo.EventMembers", new[] { "Member_Id" });
            DropIndex("dbo.EventMembers", new[] { "Event_Id" });
            DropIndex("dbo.MemberClubs", new[] { "Club_Id" });
            DropIndex("dbo.MemberClubs", new[] { "Member_Id" });
            DropIndex("dbo.Routes", new[] { "Owner_Id" });
            DropIndex("dbo.Events", new[] { "Route_Id" });
            DropIndex("dbo.Events", new[] { "Owner_Id" });
            DropTable("dbo.EventMembers");
            DropTable("dbo.MemberClubs");
            DropTable("dbo.Routes");
            DropTable("dbo.Events");
            DropTable("dbo.Members");
            DropTable("dbo.Clubs");
        }
    }
}
