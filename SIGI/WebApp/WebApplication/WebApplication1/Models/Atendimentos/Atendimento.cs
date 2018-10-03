using SIGI.Models.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.Models.Atendimentos
{
    public class Atendimento
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int FuncionarioID { get; set; }
        public Pessoa Funcionario { get; set; }
        public int ClienteID { get; set; }
        public Pessoa Cliente { get; set; }
        public EResultado Resultado { get; set; }
        public string Relatorio { get; set; }
        public DateTime DataAtendimento { get; set; }
    }
}