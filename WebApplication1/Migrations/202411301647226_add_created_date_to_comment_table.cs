namespace BlogApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_created_date_to_comment_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "CreatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "CreatedDate");
        }
    }
}
