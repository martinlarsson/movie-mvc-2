namespace MovieMVC2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Bio = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Character = c.String(),
                        ActorID = c.Int(),
                        MovieID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Actors", t => t.ActorID)
                .ForeignKey("dbo.Movies", t => t.MovieID)
                .Index(t => t.ActorID)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Rank = c.Int(nullable: false),
                        Genre = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.Roles", "ActorID", "dbo.Actors");
            DropIndex("dbo.Roles", new[] { "MovieID" });
            DropIndex("dbo.Roles", new[] { "ActorID" });
            DropTable("dbo.Movies");
            DropTable("dbo.Roles");
            DropTable("dbo.Actors");
        }
    }
}
