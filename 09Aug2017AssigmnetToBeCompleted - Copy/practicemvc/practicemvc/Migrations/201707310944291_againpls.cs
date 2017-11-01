namespace practicemvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class againpls : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.dbases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        IsSubscribedToNewsLetter = c.Boolean(nullable: false),
                        MembershipTypeId = c.Byte(nullable: false),
                        Birthdate = c.DateTime(),
                        MemberType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MemberTypes", t => t.MemberType_Id)
                .Index(t => t.MemberType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.dbases", "MemberType_Id", "dbo.MemberTypes");
            DropIndex("dbo.dbases", new[] { "MemberType_Id" });
            DropTable("dbo.dbases");
        }
    }
}
