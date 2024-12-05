namespace FermMad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Ferm_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ferms", t => t.Ferm_Id)
                .Index(t => t.Ferm_Id);
            
            CreateTable(
                "dbo.Ferms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "Ferm_Id", "dbo.Ferms");
            DropIndex("dbo.Animals", new[] { "Ferm_Id" });
            DropTable("dbo.Ferms");
            DropTable("dbo.Animals");
        }
    }
}
