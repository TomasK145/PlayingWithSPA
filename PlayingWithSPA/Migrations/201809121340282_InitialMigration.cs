namespace PlayingWithSPA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Checked = c.Boolean(nullable: false),
                        ShoppingListId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShoppingLists", t => t.ShoppingListId, cascadeDelete: true)
                .Index(t => t.ShoppingListId);
            
            CreateTable(
                "dbo.ShoppingLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "ShoppingListId", "dbo.ShoppingLists");
            DropIndex("dbo.Items", new[] { "ShoppingListId" });
            DropTable("dbo.ShoppingLists");
            DropTable("dbo.Items");
        }
    }
}
