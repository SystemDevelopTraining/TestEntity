namespace TestEntity.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Kainn_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "KainnId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "KainnId", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "Kainn_Id");
        }
    }
}
