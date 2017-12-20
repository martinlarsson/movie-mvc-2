namespace MovieMVC2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotationsForActor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Actors", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Actors", "Name", c => c.String());
        }
    }
}
