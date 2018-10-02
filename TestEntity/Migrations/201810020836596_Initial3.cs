namespace TestEntity.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Kaiin_Id", "dbo.Kaiins");
            DropIndex("dbo.Orders", new[] { "Kaiin_Id" });
            AddColumn("dbo.Orders", "Kaiin_Id1", c => c.Int());
            AlterColumn("dbo.Orders", "Kaiin_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "Kaiin_Id1");
            AddForeignKey("dbo.Orders", "Kaiin_Id1", "dbo.Kaiins", "Id");
            DropColumn("dbo.Orders", "Kaiinn_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Kaiinn_Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.Orders", "Kaiin_Id1", "dbo.Kaiins");
            DropIndex("dbo.Orders", new[] { "Kaiin_Id1" });
            AlterColumn("dbo.Orders", "Kaiin_Id", c => c.Int());
            DropColumn("dbo.Orders", "Kaiin_Id1");
            CreateIndex("dbo.Orders", "Kaiin_Id");
            AddForeignKey("dbo.Orders", "Kaiin_Id", "dbo.Kaiins", "Id");
        }
    }
}
