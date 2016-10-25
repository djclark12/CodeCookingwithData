namespace CodeCookingwithData.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PassingStatsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PassingStatsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerId = c.String(),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Team = c.String(),
                        IsAway = c.Boolean(nullable: false),
                        OppTeam = c.String(),
                        Result = c.String(),
                        GameNum = c.Int(nullable: false),
                        Week = c.Int(nullable: false),
                        DayOfWeek = c.Int(nullable: false),
                        Completions = c.Int(nullable: false),
                        Attempts = c.Int(nullable: false),
                        CmpPercent = c.Int(nullable: false),
                        Yds = c.Int(nullable: false),
                        Tds = c.Int(nullable: false),
                        Interceptions = c.Int(nullable: false),
                        Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        YdsperAtt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AdjYdsperAtt = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PassingStatsModels");
        }
    }
}
