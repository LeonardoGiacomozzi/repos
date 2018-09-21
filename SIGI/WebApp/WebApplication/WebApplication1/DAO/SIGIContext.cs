using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGI.Models.CadastroEndereco;
using System.Data.Entity;
using SIGI.Models.CadastroImovel;
using SIGI.Models.CadastroImovel.ListaDetalhes;
using SIGI.Models.CadastroImovel.ListaDocumentos;

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
        //public DbSet<Detalhes> Detalhes{ get; set; }
        //public DbSet<Documentos> Documentos { get; set; }


    }
}