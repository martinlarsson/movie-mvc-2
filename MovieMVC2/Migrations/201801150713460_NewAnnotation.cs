namespace MovieMVC2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Actors", "Bio", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Actors", "Bio", c => c.String());
        }
    }
}
