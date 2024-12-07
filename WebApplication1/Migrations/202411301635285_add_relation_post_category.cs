namespace BlogApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_relation_post_category : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Posts", "Body", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Posts", "CreatedDate", c => c.DateTime());
            CreateIndex("dbo.Posts", "CategoryId");
            AddForeignKey("dbo.Posts", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "CategoryId" });
            AlterColumn("dbo.Posts", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Posts", "Body", c => c.String());
            AlterColumn("dbo.Posts", "Title", c => c.String());
            DropColumn("dbo.Posts", "CategoryId");
        }
    }
}
