namespace Assigment5Diksha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "PhoneNo", c => c.String(nullable: false));
            DropColumn("dbo.Employees", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Phone", c => c.String(nullable: false));
            DropColumn("dbo.Employees", "PhoneNo");
        }
    }
}
