namespace JustGoRide.cc.Providers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Base2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Events", name: "Owner_Id", newName: "OwnerId");
            RenameColumn(table: "dbo.Routes", name: "Owner_Id", newName: "OwnerId");
            RenameIndex(table: "dbo.Events", name: "IX_Owner_Id", newName: "IX_OwnerId");
            RenameIndex(table: "dbo.Routes", name: "IX_Owner_Id", newName: "IX_OwnerId");
            AddColumn("dbo.Clubs", "DateModified", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clubs", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Members", "DateModified", c => c.DateTime(nullable: false));
            AddColumn("dbo.Members", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Events", "DateModified", c => c.DateTime(nullable: false));
            AddColumn("dbo.Events", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Routes", "DateModified", c => c.DateTime(nullable: false));
            AddColumn("dbo.Routes", "DateCreated", c => c.DateTime(nullable: false));
            DropColumn("dbo.Clubs", "CreatedOn");
            DropColumn("dbo.Members", "JoinedOn");
            DropColumn("dbo.Events", "CreatedOn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Members", "JoinedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clubs", "CreatedOn", c => c.DateTime(nullable: false));
            DropColumn("dbo.Routes", "DateCreated");
            DropColumn("dbo.Routes", "DateModified");
            DropColumn("dbo.Events", "DateCreated");
            DropColumn("dbo.Events", "DateModified");
            DropColumn("dbo.Members", "DateCreated");
            DropColumn("dbo.Members", "DateModified");
            DropColumn("dbo.Clubs", "DateCreated");
            DropColumn("dbo.Clubs", "DateModified");
            RenameIndex(table: "dbo.Routes", name: "IX_OwnerId", newName: "IX_Owner_Id");
            RenameIndex(table: "dbo.Events", name: "IX_OwnerId", newName: "IX_Owner_Id");
            RenameColumn(table: "dbo.Routes", name: "OwnerId", newName: "Owner_Id");
            RenameColumn(table: "dbo.Events", name: "OwnerId", newName: "Owner_Id");
        }
    }
}
