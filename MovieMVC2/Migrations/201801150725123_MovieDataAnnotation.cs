namespace MovieMVC2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieDataAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.String());
            AlterColumn("dbo.Movies", "Title", c => c.String());
        }
    }
}
