namespace IvanAgencyService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OplataMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "SummaOplaty", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "SummaOplaty");
        }
    }
}
