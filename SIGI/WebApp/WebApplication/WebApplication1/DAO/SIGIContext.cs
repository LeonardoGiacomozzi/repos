using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGI.Models.CadastroEndereco;
using System.Data.Entity;
using WebApplication1.Models.CadastroImovel;
using SIGI.Models.CadastroImovel;
using SIGI.Models.CadastroImovel.ListaDetalhes;
using WebApplication1.Models.CadastroImovel.ListaDocumentos;
using SIGI.Models.CadastroImovel.Caracteristicas;
using SIGI.Models.Usuarios;
using SIGI.Models.CadastroImovel.Valores;
using SIGI.Models.Pessoas;

namespace SIGI.DAO
{
    public class SIGIContext : DbContext
    {
        //passo a string connection por contrutor para o  super
        public SIGIContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SIGIDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
        }
        //CADASTRO DE ENDEREÇOS
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Cidade> Cidade { get; set; }

        public DbSet<Estado> Estado { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        //CADASTRO DE IMÓVEIS
        public DbSet<Anexo> Anexo{ get; set; }
        public DbSet<Crm> CRM{ get; set; }
        public DbSet<Detalhes> Detalhes{ get; set; }
        public DbSet<Documentos> Documentos{ get; set; }
        public DbSet<CaracteristicaPrincipal> CaracteristicaPrincipal{ get; set; }
        public DbSet<CaracteristicasGerais> CaracteristicasGerais { get; set; }
        public DbSet<ValorLocacao> ValorLocacao { get; set; }
        public DbSet<ValorVenda> ValorVenda { get; set; }
        public DbSet<Imovel> Imovel { get;  set; }
        //USUARIO
        public DbSet<Usuario> Usuario { get; set; }
        //PESSOAS
        public DbSet<PessoaFisica> PessoaFisica { get; internal set; }
    }
}