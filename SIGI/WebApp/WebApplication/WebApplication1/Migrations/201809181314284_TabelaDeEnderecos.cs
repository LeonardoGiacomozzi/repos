namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaDeEnderecos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CEP = c.String(),
                        Numero = c.Int(nullable: false),
                        Rua = c.String(),
                        Bairro = c.String(),
                        CidadeID = c.Int(nullable: false),
                        EstadoID = c.Int(nullable: false),
                        PaisID = c.Int(nullable: false),
                        Complemento = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cidades", t => t.CidadeID, cascadeDelete: true)
                .ForeignKey("dbo.Estadoes", t => t.EstadoID, cascadeDelete: true)
                .ForeignKey("dbo.Pais", t => t.PaisID, cascadeDelete: true)
                .Index(t => t.CidadeID)
                .Index(t => t.EstadoID)
                .Index(t => t.PaisID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enderecoes", "PaisID", "dbo.Pais");
            DropForeignKey("dbo.Enderecoes", "EstadoID", "dbo.Estadoes");
            DropForeignKey("dbo.Enderecoes", "CidadeID", "dbo.Cidades");
            DropIndex("dbo.Enderecoes", new[] { "PaisID" });
            DropIndex("dbo.Enderecoes", new[] { "EstadoID" });
            DropIndex("dbo.Enderecoes", new[] { "CidadeID" });
            DropTable("dbo.Enderecoes");
        }
    }
}
