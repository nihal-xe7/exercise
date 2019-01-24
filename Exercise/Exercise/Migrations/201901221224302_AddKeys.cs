namespace Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKeys : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MemberShipID", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "MemberShipID");
            AddForeignKey("dbo.Customers", "MemberShipID", "dbo.MemberShips", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipID", "dbo.MemberShips");
            DropIndex("dbo.Customers", new[] { "MemberShipID" });
            DropColumn("dbo.Customers", "MemberShipID");
        }
    }
}
