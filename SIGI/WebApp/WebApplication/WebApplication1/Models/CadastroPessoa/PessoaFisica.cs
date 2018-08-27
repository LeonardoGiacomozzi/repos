using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGI.Models.Pessoas
{
    public class PessoaFisica:Pessoa
    {
        public ETipoPessoa eTipo { get; private set; }
        public string Nome { get; set; }
        //public string Apelido { get; set; }
        //public string Atividade { get; set; }
        public string Profissao { get; set; }
        public EEstadoCivil EEstadoCivil { get; set; }
        public string Nacionalidade { get; set; }
        //public string NomePai { get; set; }
       // public string NomeMae { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Cpf { get; set; }
        public string Rg{ get; set; }
      //data  public string Local { get; set; }
        public DateTime DataNascimento { get; set; }
        public string EmailPrincipal { get; set; }
        public string EmailSecundario { get; set; }
        public string WebSite { get; set; }
        public string Observacao { get; set; }
        public Endereco Endereco{ get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        //public string Operadora { get; set; }


        public PessoaFisica()
        {
        }
    }
}
