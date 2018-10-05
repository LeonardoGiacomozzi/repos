namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Atendimentoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        FuncionarioID = c.Int(nullable: false),
                        ClienteID = c.Int(nullable: false),
                        Resultado = c.Int(nullable: false),
                        Relatorio = c.String(),
                        DataAtendimento = c.DateTime(nullable: false),
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
                .ForeignKey("dbo.Enderecoes", t => t.EnderecoID, cascadeDelete: false)
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
                "dbo.Imovels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
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
                        CaracteristicasPrincipais = c.String(),
                        CaracteristicasGerais = c.String(),
                        ValorID = c.Int(nullable: false),
                        AtendimentoID = c.Int(nullable: false),
                        Detalhes = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Atendimentoes", t => t.AtendimentoID, cascadeDelete: false)
                .ForeignKey("dbo.Enderecoes", t => t.EnderecoID, cascadeDelete: true)
                .ForeignKey("dbo.Pessoas", t => t.ResponsavelID, cascadeDelete: true)
                .ForeignKey("dbo.Valors", t => t.ValorID, cascadeDelete: true)
                .Index(t => t.EnderecoID)
                .Index(t => t.ResponsavelID)
                .Index(t => t.ValorID)
                .Index(t => t.AtendimentoID);
            
            CreateTable(
                "dbo.Valors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tipo = c.Int(nullable: false),
                        ValorDeVenda = c.Double(nullable: false),
                        PodeFinanciar = c.Boolean(nullable: false),
                        EstaEsscriturado = c.Boolean(nullable: false),
                        EstaAverbado = c.Boolean(nullable: false),
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
            DropForeignKey("dbo.Imovels", "ValorID", "dbo.Valors");
            DropForeignKey("dbo.Imovels", "ResponsavelID", "dbo.Pessoas");
            DropForeignKey("dbo.Imovels", "EnderecoID", "dbo.Enderecoes");
            DropForeignKey("dbo.Imovels", "AtendimentoID", "dbo.Atendimentoes");
            DropForeignKey("dbo.Atendimentoes", "FuncionarioID", "dbo.Pessoas");
            DropForeignKey("dbo.Atendimentoes", "ClienteID", "dbo.Pessoas");
            DropForeignKey("dbo.Pessoas", "EnderecoID", "dbo.Enderecoes");
            DropForeignKey("dbo.Enderecoes", "CidadeID", "dbo.Cidades");
            DropForeignKey("dbo.Cidades", "EstadoID", "dbo.Estadoes");
            DropForeignKey("dbo.Estadoes", "PaisID", "dbo.Pais");
            DropIndex("dbo.Imovels", new[] { "AtendimentoID" });
            DropIndex("dbo.Imovels", new[] { "ValorID" });
            DropIndex("dbo.Imovels", new[] { "ResponsavelID" });
            DropIndex("dbo.Imovels", new[] { "EnderecoID" });
            DropIndex("dbo.Estadoes", new[] { "PaisID" });
            DropIndex("dbo.Cidades", new[] { "EstadoID" });
            DropIndex("dbo.Enderecoes", new[] { "CidadeID" });
            DropIndex("dbo.Pessoas", new[] { "EnderecoID" });
            DropIndex("dbo.Atendimentoes", new[] { "ClienteID" });
            DropIndex("dbo.Atendimentoes", new[] { "FuncionarioID" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Valors");
            DropTable("dbo.Imovels");
            DropTable("dbo.Pais");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Cidades");
            DropTable("dbo.Enderecoes");
            DropTable("dbo.Pessoas");
            DropTable("dbo.Atendimentoes");
        }
    }
}
