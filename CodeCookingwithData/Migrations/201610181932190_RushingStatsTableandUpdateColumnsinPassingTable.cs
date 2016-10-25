namespace CodeCookingwithData.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RushingStatsTableandUpdateColumnsinPassingTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RushingStatsModels",
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
                        DayOfWeek = c.Int(nullable: false),
                        RushAtt = c.Int(nullable: false),
                        RushYds = c.Int(nullable: false),
                        RushYdsperAtt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RushTds = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.PassingStatsModels", "PassCmp", c => c.Int(nullable: false));
            AddColumn("dbo.PassingStatsModels", "PassAtt", c => c.Int(nullable: false));
            AddColumn("dbo.PassingStatsModels", "PassYds", c => c.Int(nullable: false));
            AddColumn("dbo.PassingStatsModels", "PassTds", c => c.Int(nullable: false));
            AddColumn("dbo.PassingStatsModels", "PassYdsperAtt", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PassingStatsModels", "PassAdjYdsperAtt", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.PassingStatsModels", "Completions");
            DropColumn("dbo.PassingStatsModels", "Attempts");
            DropColumn("dbo.PassingStatsModels", "Yds");
            DropColumn("dbo.PassingStatsModels", "Tds");
            DropColumn("dbo.PassingStatsModels", "YdsperAtt");
            DropColumn("dbo.PassingStatsModels", "AdjYdsperAtt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PassingStatsModels", "AdjYdsperAtt", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PassingStatsModels", "YdsperAtt", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PassingStatsModels", "Tds", c => c.Int(nullable: false));
            AddColumn("dbo.PassingStatsModels", "Yds", c => c.Int(nullable: false));
            AddColumn("dbo.PassingStatsModels", "Attempts", c => c.Int(nullable: false));
            AddColumn("dbo.PassingStatsModels", "Completions", c => c.Int(nullable: false));
            DropColumn("dbo.PassingStatsModels", "PassAdjYdsperAtt");
            DropColumn("dbo.PassingStatsModels", "PassYdsperAtt");
            DropColumn("dbo.PassingStatsModels", "PassTds");
            DropColumn("dbo.PassingStatsModels", "PassYds");
            DropColumn("dbo.PassingStatsModels", "PassAtt");
            DropColumn("dbo.PassingStatsModels", "PassCmp");
            DropTable("dbo.RushingStatsModels");
        }
    }
}
