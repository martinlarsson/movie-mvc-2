namespace MovieMVC2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Roles", "Character", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Roles", "Character", c => c.String());
        }
    }
}
