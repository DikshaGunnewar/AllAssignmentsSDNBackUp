namespace PracticeAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialTable1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.States", "Abbr");
        }
        
        public override void Down()
        {
            AddColumn("dbo.States", "Abbr", c => c.String());
        }
    }
}
