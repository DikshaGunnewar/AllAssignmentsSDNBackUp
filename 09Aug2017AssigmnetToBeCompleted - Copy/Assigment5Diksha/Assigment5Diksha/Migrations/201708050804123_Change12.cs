namespace Assigment5Diksha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Phone", c => c.Long(nullable: false));
        }
    }
}
