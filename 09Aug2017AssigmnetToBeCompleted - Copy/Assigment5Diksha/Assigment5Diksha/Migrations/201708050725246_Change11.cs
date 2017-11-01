namespace Assigment5Diksha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Id");
        }
    }
}
