namespace TestEntity.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Kaiinn_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "Kainn_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Kainn_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "Kaiinn_Id");
        }
    }
}
