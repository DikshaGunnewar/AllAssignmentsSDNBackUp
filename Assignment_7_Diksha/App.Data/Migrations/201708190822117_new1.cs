namespace App.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "image");
        }
    }
}
