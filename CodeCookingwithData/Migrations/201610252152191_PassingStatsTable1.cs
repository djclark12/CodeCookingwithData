namespace CodeCookingwithData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PassingStatsTable1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PassingStatsModels", "CmpPercent", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PassingStatsModels", "CmpPercent", c => c.Int(nullable: false));
        }
    }
}
