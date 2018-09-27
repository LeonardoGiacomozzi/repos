using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.Models.CadastroImovel.Valores
{
    public class ValorVenda:IValor
    {
        public int ID { get; set; }
        public double ValorDeVenda { get; set; }
        public bool PodeFinanciar { get; set; }
        public bool EstaEsscriturado { get; set; }
        public bool EstaAverbado { get; set; }
        public string DescricaoPagamento { get; set; }
    }
}