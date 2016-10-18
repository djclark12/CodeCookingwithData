namespace CodeCookingwithData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReceivingTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReceiverStatsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerId = c.String(),
                        PlayerName = c.String(),
                        Age = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Team = c.String(),
                        IsAway = c.Boolean(nullable: false),
                        OppTeam = c.String(),
                        Result = c.String(),
                        GameNum = c.Int(nullable: false),
                        Week = c.Int(nullable: false),
                        DayOfWeek = c.Int(nullable: false),
                        Targets = c.Int(nullable: false),
                        Receptions = c.Int(nullable: false),
                        RecYds = c.Int(nullable: false),
                        YdsperRec = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RecTds = c.Int(nullable: false),
                        CtchPercent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        YdsperTgt = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.RushingStatsModels", "Week", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RushingStatsModels", "Week");
            DropTable("dbo.ReceiverStatsModels");
        }
    }
}
