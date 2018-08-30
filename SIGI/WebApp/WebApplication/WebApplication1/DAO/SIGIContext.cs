using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGI.Models.CadastroEndereco;
using System.Data.Entity;

namespace SIGI.DAO
{
    public class SIGIContext : DbContext
    {
        //passo a string connection por contrutor para o  super
        public SIGIContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SIGIDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
        }
        public DbSet<Pais> Pais { get; set; }

        public DbSet<Estado> Estado { get; set; }

    }
}