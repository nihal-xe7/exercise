namespace Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 12));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Password");
        }
    }
}
