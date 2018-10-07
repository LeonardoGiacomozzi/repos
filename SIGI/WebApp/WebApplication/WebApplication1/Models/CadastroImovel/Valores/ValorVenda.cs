using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.Models.CadastroImovel.Valores
{
    public class Valor
    {
        public int ID { get; set; }
        public ETipoNegocio Tipo { get; set; }
        public double ValorDeVenda { get; set; }
        public bool PodeFinanciar { get; set; }
        public bool EstaEsscriturado { get; set; }
        public bool EstaAverbado { get; set; }
        public double IPTU { get; set; }
        public double Condominio { get; set; }
        public double Mensalidade { get; set; }
        public string DescricaoPagamento { get; set; }
        public double Comissao { get; set; }
    }
}