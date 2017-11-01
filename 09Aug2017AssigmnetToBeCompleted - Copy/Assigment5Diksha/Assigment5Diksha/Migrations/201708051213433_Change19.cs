namespace Assigment5Diksha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change19 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "EmployeeG_EmployeeId", "dbo.EmployeeGs");
            DropForeignKey("dbo.States", "EmployeeG_EmployeeId", "dbo.EmployeeGs");
            DropIndex("dbo.Cities", new[] { "EmployeeG_EmployeeId" });
            DropIndex("dbo.States", new[] { "EmployeeG_EmployeeId" });
            AlterColumn("dbo.Employees", "State", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "City", c => c.Int(nullable: false));
            DropColumn("dbo.Cities", "EmployeeG_EmployeeId");
            DropColumn("dbo.States", "EmployeeG_EmployeeId");
            DropTable("dbo.EmployeeGs");
        }
        
        public override void Down()
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
            
            AddColumn("dbo.States", "EmployeeG_EmployeeId", c => c.Int());
            AddColumn("dbo.Cities", "EmployeeG_EmployeeId", c => c.Int());
            AlterColumn("dbo.Employees", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "State", c => c.String(nullable: false));
            CreateIndex("dbo.States", "EmployeeG_EmployeeId");
            CreateIndex("dbo.Cities", "EmployeeG_EmployeeId");
            AddForeignKey("dbo.States", "EmployeeG_EmployeeId", "dbo.EmployeeGs", "EmployeeId");
            AddForeignKey("dbo.Cities", "EmployeeG_EmployeeId", "dbo.EmployeeGs", "EmployeeId");
        }
    }
}
