using SIGI.Models.CadastroEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.Models.Pessoas
{
    public class PessoaJuridica:IPessoa
    {
        public ETipoPessoa ETipo { get; private set; }
        public string NomeEmpresa { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Cnpj { get; set; }
        public string EmailPrincipal { get; set; }
        public string WebSite { get; set; }
        public string Observacao { get; set; }
        public Endereco Endereco{ get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

    }
}