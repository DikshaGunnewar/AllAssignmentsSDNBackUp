namespace CountryStateNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rEMOVEoNEdATA : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Country12", "Abbr");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Country12", "Abbr", c => c.String());
        }
    }
}
