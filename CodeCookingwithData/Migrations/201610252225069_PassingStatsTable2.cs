namespace CodeCookingwithData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PassingStatsTable2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PassingStatsModels", "DayOfWeek", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PassingStatsModels", "DayOfWeek", c => c.Int(nullable: false));
        }
    }
}
