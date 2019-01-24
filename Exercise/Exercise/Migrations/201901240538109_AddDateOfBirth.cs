namespace Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateOfBirth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DOB", c => c.String(nullable:true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DOB");
        }
    }
}
