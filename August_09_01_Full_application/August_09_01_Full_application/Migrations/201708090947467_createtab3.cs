namespace August_09_01_Full_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtab3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentViewModels",
                c => new
                    {
                        Stud_id = c.Int(nullable: false, identity: true),
                        Stud_fname = c.String(),
                        Stud_lname = c.String(),
                        Stud_std = c.Int(nullable: false),
                        Stud_group = c.String(),
                        Stud_cousre = c.String(),
                        age = c.Int(nullable: false),
                        Stud_addr_id = c.Int(nullable: false),
                        Stud_area = c.String(),
                        Stud_street = c.String(),
                        Stud_city = c.String(),
                        Stud_zipcode = c.String(),
                    })
                .PrimaryKey(t => t.Stud_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentViewModels");
        }
    }
}
