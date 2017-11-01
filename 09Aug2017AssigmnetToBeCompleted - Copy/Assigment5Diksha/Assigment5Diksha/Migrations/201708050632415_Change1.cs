namespace Assigment5Diksha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeVMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Employees_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employees_EmployeeId)
                .Index(t => t.Employees_EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeVMs", "Employees_EmployeeId", "dbo.Employees");
            DropIndex("dbo.EmployeeVMs", new[] { "Employees_EmployeeId" });
            DropTable("dbo.EmployeeVMs");
        }
    }
}
