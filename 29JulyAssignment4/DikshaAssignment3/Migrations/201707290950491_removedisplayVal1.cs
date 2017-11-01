namespace DikshaAssignment3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedisplayVal1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student1", "Qualification", c => c.String());
            AlterColumn("dbo.Student1", "MaritialStatus", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student1", "MaritialStatus", c => c.String(nullable: false));
            AlterColumn("dbo.Student1", "Qualification", c => c.String(nullable: false));
        }
    }
}
