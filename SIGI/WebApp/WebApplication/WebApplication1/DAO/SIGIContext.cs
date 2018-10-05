using SIGI.Models.CadastroEndereco;
using System.Data.Entity;
using SIGI.Models.CadastroImovel;
using SIGI.Models.Usuarios;
using SIGI.Models.CadastroImovel.Valores;
using SIGI.Models.Pessoas;
using SIGI.Models.Atendimentos;

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
        public DbSet<Valor> ValorVenda { get; set; }
        public DbSet<Imovel> Imovel { get;  set; }
       
        public DbSet<Atendimento> Atendimento { get; set; }

        //USUARIO
        public DbSet<Usuario> Usuario { get; set; }
        //PESSOAS
        public DbSet<Pessoa> Pessoa{ get; set; }
       }
}