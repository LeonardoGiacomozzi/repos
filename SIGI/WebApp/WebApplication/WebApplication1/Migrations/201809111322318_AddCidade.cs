namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCidade : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        EstadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Estadoes", t => t.EstadoID, cascadeDelete: true)
                .Index(t => t.EstadoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cidades", "EstadoID", "dbo.Estadoes");
            DropIndex("dbo.Cidades", new[] { "EstadoID" });
            DropTable("dbo.Cidades");
        }
    }
}
