namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Anexoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Imovel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Imovels", t => t.Imovel_ID)
                .Index(t => t.Imovel_ID);
            
            CreateTable(
                "dbo.CaracteristicaPrincipals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TipoDeDado = c.Int(nullable: false),
                        Nome = c.String(),
                        Valor = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Imovel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Imovels", t => t.Imovel_ID)
                .Index(t => t.Imovel_ID);
            
            CreateTable(
                "dbo.CaracteristicasGerais",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TipoDeDado = c.Int(nullable: false),
                        Nome = c.String(),
                        Valor = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Imovel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Imovels", t => t.Imovel_ID)
                .Index(t => t.Imovel_ID);
            
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
                        Imovel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Imovels", t => t.Imovel_ID)
                .Index(t => t.Imovel_ID);
            
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
                        Imovel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Imovels", t => t.Imovel_ID)
                .Index(t => t.Imovel_ID);
            
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
            
            CreateTable(
                "dbo.Imovels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DescricaoBreve = c.String(),
                        DescricaoCompleta = c.String(),
                        TipoNegocio = c.Int(nullable: false),
                        TipoDeImovel = c.Int(nullable: false),
                        Finalidade = c.Int(nullable: false),
                        CdgIntegracao_Origem = c.String(),
                        CdgIntegracao_Codigo = c.String(),
                        MetragemUtil = c.Double(nullable: false),
                        MetragemTotal = c.Double(nullable: false),
                        Detalhes_ID = c.Int(),
                        Endereco_ID = c.Int(),
                        ValorDeVenda_ID = c.Int(),
                        ValorLocacao_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Detalhes", t => t.Detalhes_ID)
                .ForeignKey("dbo.Enderecoes", t => t.Endereco_ID)
                .ForeignKey("dbo.ValorVendas", t => t.ValorDeVenda_ID)
                .ForeignKey("dbo.ValorLocacaos", t => t.ValorLocacao_ID)
                .Index(t => t.Detalhes_ID)
                .Index(t => t.Endereco_ID)
                .Index(t => t.ValorDeVenda_ID)
                .Index(t => t.ValorLocacao_ID);
            
            CreateTable(
                "dbo.ValorVendas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ValorDeVenda = c.Double(nullable: false),
                        PodeFinanciar = c.Boolean(nullable: false),
                        EstaEsscriturado = c.Boolean(nullable: false),
                        EstaAverbado = c.Boolean(nullable: false),
                        DescricaoPagamento = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ValorLocacaos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IPTU = c.Double(nullable: false),
                        Condominio = c.Double(nullable: false),
                        Mensalidade = c.Double(nullable: false),
                        DescricaoPagamento = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Senha = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Imovels", "ValorLocacao_ID", "dbo.ValorLocacaos");
            DropForeignKey("dbo.Imovels", "ValorDeVenda_ID", "dbo.ValorVendas");
            DropForeignKey("dbo.Imovels", "Endereco_ID", "dbo.Enderecoes");
            DropForeignKey("dbo.Documentos", "Imovel_ID", "dbo.Imovels");
            DropForeignKey("dbo.Imovels", "Detalhes_ID", "dbo.Detalhes");
            DropForeignKey("dbo.Crms", "Imovel_ID", "dbo.Imovels");
            DropForeignKey("dbo.CaracteristicaPrincipals", "Imovel_ID", "dbo.Imovels");
            DropForeignKey("dbo.CaracteristicasGerais", "Imovel_ID", "dbo.Imovels");
            DropForeignKey("dbo.Anexoes", "Imovel_ID", "dbo.Imovels");
            DropForeignKey("dbo.Enderecoes", "PaisID", "dbo.Pais");
            DropForeignKey("dbo.Enderecoes", "EstadoID", "dbo.Estadoes");
            DropForeignKey("dbo.Enderecoes", "CidadeID", "dbo.Cidades");
            DropForeignKey("dbo.Cidades", "EstadoID", "dbo.Estadoes");
            DropForeignKey("dbo.Estadoes", "PaisID", "dbo.Pais");
            DropIndex("dbo.Imovels", new[] { "ValorLocacao_ID" });
            DropIndex("dbo.Imovels", new[] { "ValorDeVenda_ID" });
            DropIndex("dbo.Imovels", new[] { "Endereco_ID" });
            DropIndex("dbo.Imovels", new[] { "Detalhes_ID" });
            DropIndex("dbo.Enderecoes", new[] { "PaisID" });
            DropIndex("dbo.Enderecoes", new[] { "EstadoID" });
            DropIndex("dbo.Enderecoes", new[] { "CidadeID" });
            DropIndex("dbo.Documentos", new[] { "Imovel_ID" });
            DropIndex("dbo.Crms", new[] { "Imovel_ID" });
            DropIndex("dbo.Estadoes", new[] { "PaisID" });
            DropIndex("dbo.Cidades", new[] { "EstadoID" });
            DropIndex("dbo.CaracteristicasGerais", new[] { "Imovel_ID" });
            DropIndex("dbo.CaracteristicaPrincipals", new[] { "Imovel_ID" });
            DropIndex("dbo.Anexoes", new[] { "Imovel_ID" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.ValorLocacaos");
            DropTable("dbo.ValorVendas");
            DropTable("dbo.Imovels");
            DropTable("dbo.Enderecoes");
            DropTable("dbo.Documentos");
            DropTable("dbo.Detalhes");
            DropTable("dbo.Crms");
            DropTable("dbo.Pais");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Cidades");
            DropTable("dbo.CaracteristicasGerais");
            DropTable("dbo.CaracteristicaPrincipals");
            DropTable("dbo.Anexoes");
        }
    }
}
