namespace BlogApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_relation_reaction_to_post_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reactions", "PostId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reactions", "PostId");
            AddForeignKey("dbo.Reactions", "PostId", "dbo.Posts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reactions", "PostId", "dbo.Posts");
            DropIndex("dbo.Reactions", new[] { "PostId" });
            DropColumn("dbo.Reactions", "PostId");
        }
    }
}
