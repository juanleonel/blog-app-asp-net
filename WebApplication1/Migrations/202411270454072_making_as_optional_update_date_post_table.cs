namespace BlogApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class making_as_optional_update_date_post_table : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "UpdatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "UpdatedDate", c => c.DateTime(nullable: false));
        }
    }
}
