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
                        Imovel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Imovels", t => t.Imovel_ID)
                .Index(t => t.Imovel_ID);
            
            CreateTable(
                "dbo.Atendimentoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FuncionarioID = c.Int(nullable: false),
                        ClienteID = c.Int(nullable: false),
                        Resultado = c.Int(nullable: false),
                        Relatorio = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pessoas", t => t.ClienteID, cascadeDelete: false)
                .ForeignKey("dbo.Pessoas", t => t.FuncionarioID, cascadeDelete: false)
                .Index(t => t.FuncionarioID)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TipoPessoa = c.Int(nullable: false),
                        ETipo = c.Int(nullable: false),
                        Nome = c.String(),
                        Profissao = c.String(),
                        EEstadoCivil = c.Int(nullable: false),
                        Nacionalidade = c.String(),
                        InscricaoMunicipal = c.String(),
                        InscricaoEstadual = c.String(),
                        Cpf = c.String(),
                        Rg = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        EmailPrincipal = c.String(),
                        Observacao = c.String(),
                        EnderecoID = c.Int(nullable: false),
                        Telefone = c.String(),
                        Celular = c.String(),
                        Cnpj = c.String(),
                        WebSite = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Enderecoes", t => t.EnderecoID, cascadeDelete: true)
                .Index(t => t.EnderecoID);
            
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
                        Complemento = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cidades", t => t.CidadeID, cascadeDelete: true)
                .Index(t => t.CidadeID);
            
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
                "dbo.CodigoIntegracaos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Origem = c.String(),
                        Codigo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
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
                "dbo.Imovels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DescricaoBreve = c.String(),
                        DescricaoCompleta = c.String(),
                        TipoNegocio = c.Int(nullable: false),
                        TipoDeImovel = c.Int(nullable: false),
                        Finalidade = c.Int(nullable: false),
                        EnderecoID = c.Int(nullable: false),
                        ResponsavelID = c.Int(nullable: false),
                        CdgIntegracaoID = c.Int(nullable: false),
                        MetragemUtil = c.Double(nullable: false),
                        MetragemTotal = c.Double(nullable: false),
                        ValorDeVendaID = c.Int(nullable: false),
                        ValorLocacaoID = c.Int(nullable: false),
                        DetalhesID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CodigoIntegracaos", t => t.CdgIntegracaoID, cascadeDelete: true)
                .ForeignKey("dbo.Detalhes", t => t.DetalhesID, cascadeDelete: true)
                .ForeignKey("dbo.Enderecoes", t => t.EnderecoID, cascadeDelete: true)
                .ForeignKey("dbo.Pessoas", t => t.ResponsavelID, cascadeDelete: false)
                .ForeignKey("dbo.ValorVendas", t => t.ValorDeVendaID, cascadeDelete: true)
                .ForeignKey("dbo.ValorLocacaos", t => t.ValorLocacaoID, cascadeDelete: true)
                .Index(t => t.EnderecoID)
                .Index(t => t.ResponsavelID)
                .Index(t => t.CdgIntegracaoID)
                .Index(t => t.ValorDeVendaID)
                .Index(t => t.ValorLocacaoID)
                .Index(t => t.DetalhesID);
            
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
            DropForeignKey("dbo.Imovels", "ValorLocacaoID", "dbo.ValorLocacaos");
            DropForeignKey("dbo.Imovels", "ValorDeVendaID", "dbo.ValorVendas");
            DropForeignKey("dbo.Imovels", "ResponsavelID", "dbo.Pessoas");
            DropForeignKey("dbo.Imovels", "EnderecoID", "dbo.Enderecoes");
            DropForeignKey("dbo.Documentos", "Imovel_ID", "dbo.Imovels");
            DropForeignKey("dbo.Imovels", "DetalhesID", "dbo.Detalhes");
            DropForeignKey("dbo.Crms", "Imovel_ID", "dbo.Imovels");
            DropForeignKey("dbo.Imovels", "CdgIntegracaoID", "dbo.CodigoIntegracaos");
            DropForeignKey("dbo.CaracteristicaPrincipals", "Imovel_ID", "dbo.Imovels");
            DropForeignKey("dbo.CaracteristicasGerais", "Imovel_ID", "dbo.Imovels");
            DropForeignKey("dbo.Anexoes", "Imovel_ID", "dbo.Imovels");
            DropForeignKey("dbo.Atendimentoes", "FuncionarioID", "dbo.Pessoas");
            DropForeignKey("dbo.Atendimentoes", "ClienteID", "dbo.Pessoas");
            DropForeignKey("dbo.Pessoas", "EnderecoID", "dbo.Enderecoes");
            DropForeignKey("dbo.Enderecoes", "CidadeID", "dbo.Cidades");
            DropForeignKey("dbo.Cidades", "EstadoID", "dbo.Estadoes");
            DropForeignKey("dbo.Estadoes", "PaisID", "dbo.Pais");
            DropIndex("dbo.Imovels", new[] { "DetalhesID" });
            DropIndex("dbo.Imovels", new[] { "ValorLocacaoID" });
            DropIndex("dbo.Imovels", new[] { "ValorDeVendaID" });
            DropIndex("dbo.Imovels", new[] { "CdgIntegracaoID" });
            DropIndex("dbo.Imovels", new[] { "ResponsavelID" });
            DropIndex("dbo.Imovels", new[] { "EnderecoID" });
            DropIndex("dbo.Documentos", new[] { "Imovel_ID" });
            DropIndex("dbo.Crms", new[] { "Imovel_ID" });
            DropIndex("dbo.CaracteristicasGerais", new[] { "Imovel_ID" });
            DropIndex("dbo.CaracteristicaPrincipals", new[] { "Imovel_ID" });
            DropIndex("dbo.Estadoes", new[] { "PaisID" });
            DropIndex("dbo.Cidades", new[] { "EstadoID" });
            DropIndex("dbo.Enderecoes", new[] { "CidadeID" });
            DropIndex("dbo.Pessoas", new[] { "EnderecoID" });
            DropIndex("dbo.Atendimentoes", new[] { "ClienteID" });
            DropIndex("dbo.Atendimentoes", new[] { "FuncionarioID" });
            DropIndex("dbo.Anexoes", new[] { "Imovel_ID" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.ValorLocacaos");
            DropTable("dbo.ValorVendas");
            DropTable("dbo.Imovels");
            DropTable("dbo.Documentos");
            DropTable("dbo.Detalhes");
            DropTable("dbo.Crms");
            DropTable("dbo.CodigoIntegracaos");
            DropTable("dbo.CaracteristicasGerais");
            DropTable("dbo.CaracteristicaPrincipals");
            DropTable("dbo.Pais");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Cidades");
            DropTable("dbo.Enderecoes");
            DropTable("dbo.Pessoas");
            DropTable("dbo.Atendimentoes");
            DropTable("dbo.Anexoes");
        }
    }
}
