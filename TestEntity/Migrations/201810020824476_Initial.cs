namespace TestEntity.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kaiins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Addres = c.String(),
                        Contact = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KainnId = c.Int(nullable: false),
                        OdDay = c.DateTime(nullable: false),
                        SeDay = c.DateTime(nullable: false),
                        Kaiin_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kaiins", t => t.Kaiin_Id)
                .Index(t => t.Kaiin_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Kaiin_Id", "dbo.Kaiins");
            DropIndex("dbo.Orders", new[] { "Kaiin_Id" });
            DropTable("dbo.Orders");
            DropTable("dbo.Kaiins");
        }
    }
}
