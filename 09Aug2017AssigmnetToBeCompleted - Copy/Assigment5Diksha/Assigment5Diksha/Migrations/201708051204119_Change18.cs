namespace Assigment5Diksha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change18 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeGs",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNo = c.String(nullable: false),
                        MaritialStatus = c.Boolean(nullable: false),
                        State = c.String(nullable: false),
                        City = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            AddColumn("dbo.Cities", "EmployeeG_EmployeeId", c => c.Int());
            AddColumn("dbo.States", "EmployeeG_EmployeeId", c => c.Int());
            CreateIndex("dbo.Cities", "EmployeeG_EmployeeId");
            CreateIndex("dbo.States", "EmployeeG_EmployeeId");
            AddForeignKey("dbo.Cities", "EmployeeG_EmployeeId", "dbo.EmployeeGs", "EmployeeId");
            AddForeignKey("dbo.States", "EmployeeG_EmployeeId", "dbo.EmployeeGs", "EmployeeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.States", "EmployeeG_EmployeeId", "dbo.EmployeeGs");
            DropForeignKey("dbo.Cities", "EmployeeG_EmployeeId", "dbo.EmployeeGs");
            DropIndex("dbo.States", new[] { "EmployeeG_EmployeeId" });
            DropIndex("dbo.Cities", new[] { "EmployeeG_EmployeeId" });
            DropColumn("dbo.States", "EmployeeG_EmployeeId");
            DropColumn("dbo.Cities", "EmployeeG_EmployeeId");
            DropTable("dbo.EmployeeGs");
        }
    }
}
