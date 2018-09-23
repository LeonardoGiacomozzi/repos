namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Anexoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
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
            
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaisID = c.Int(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pais", t => t.PaisID, cascadeDelete: true)
                .Index(t => t.PaisID);
            
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Crms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Detalhes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Documentos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                        DataDeAlteração = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
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
                .ForeignKey("dbo.Cidades", t => t.CidadeID, cascadeDelete: false)
                .ForeignKey("dbo.Estadoes", t => t.EstadoID, cascadeDelete: false)
                .ForeignKey("dbo.Pais", t => t.PaisID, cascadeDelete: false)
                .Index(t => t.CidadeID)
                .Index(t => t.EstadoID)
                .Index(t => t.PaisID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enderecoes", "PaisID", "dbo.Pais");
            DropForeignKey("dbo.Enderecoes", "EstadoID", "dbo.Estadoes");
            DropForeignKey("dbo.Enderecoes", "CidadeID", "dbo.Cidades");
            DropForeignKey("dbo.Cidades", "EstadoID", "dbo.Estadoes");
            DropForeignKey("dbo.Estadoes", "PaisID", "dbo.Pais");
            DropIndex("dbo.Enderecoes", new[] { "PaisID" });
            DropIndex("dbo.Enderecoes", new[] { "EstadoID" });
            DropIndex("dbo.Enderecoes", new[] { "CidadeID" });
            DropIndex("dbo.Estadoes", new[] { "PaisID" });
            DropIndex("dbo.Cidades", new[] { "EstadoID" });
            DropTable("dbo.Enderecoes");
            DropTable("dbo.Documentos");
            DropTable("dbo.Detalhes");
            DropTable("dbo.Crms");
            DropTable("dbo.Pais");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Cidades");
            DropTable("dbo.Anexoes");
        }
    }
}
