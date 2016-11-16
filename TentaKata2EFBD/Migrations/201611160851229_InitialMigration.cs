namespace TentaKata2EFBD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Barriers",
                c => new
                    {
                        BarrierID = c.Int(nullable: false, identity: true),
                        BarrierName = c.String(),
                        Exit_ExitID = c.Int(),
                    })
                .PrimaryKey(t => t.BarrierID)
                .ForeignKey("dbo.Exits", t => t.Exit_ExitID)
                .Index(t => t.Exit_ExitID);
            
            CreateTable(
                "dbo.Exits",
                c => new
                    {
                        ExitID = c.Int(nullable: false, identity: true),
                        ExitName = c.String(),
                        Station_StationID = c.Int(),
                    })
                .PrimaryKey(t => t.ExitID)
                .ForeignKey("dbo.Stations", t => t.Station_StationID)
                .Index(t => t.Station_StationID);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        StationID = c.Int(nullable: false, identity: true),
                        StationName = c.String(),
                        Line_LineID = c.Int(),
                    })
                .PrimaryKey(t => t.StationID)
                .ForeignKey("dbo.Lines", t => t.Line_LineID)
                .Index(t => t.Line_LineID);
            
            CreateTable(
                "dbo.Lines",
                c => new
                    {
                        LineID = c.Int(nullable: false, identity: true),
                        LineName = c.String(),
                    })
                .PrimaryKey(t => t.LineID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stations", "Line_LineID", "dbo.Lines");
            DropForeignKey("dbo.Exits", "Station_StationID", "dbo.Stations");
            DropForeignKey("dbo.Barriers", "Exit_ExitID", "dbo.Exits");
            DropIndex("dbo.Stations", new[] { "Line_LineID" });
            DropIndex("dbo.Exits", new[] { "Station_StationID" });
            DropIndex("dbo.Barriers", new[] { "Exit_ExitID" });
            DropTable("dbo.Lines");
            DropTable("dbo.Stations");
            DropTable("dbo.Exits");
            DropTable("dbo.Barriers");
        }
    }
}
