namespace Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "DOB");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DOB", c => c.DateTime(nullable: false));
        }
    }
}
