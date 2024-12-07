namespace BlogApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_update_date_post_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "UpdatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "UpdatedDate");
        }
    }
}
