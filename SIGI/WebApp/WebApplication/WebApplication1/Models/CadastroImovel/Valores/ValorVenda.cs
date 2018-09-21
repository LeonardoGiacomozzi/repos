using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.CadastroImovel.Valores
{
    public class ValorVenda:Valor
    {
        public double ValorDeVenda { get; set; }
        //public bool Permuta { get; set; }
        public bool PodeFinanciar { get; set; }
        public bool EstaEsscriturado { get; set; }
        public bool EstaAverbado { get; set; }
        //public bool EstaFinanciado { get; set; }
        //public double ValorDivida { get; set; }
        //public int NumeroParcelasRestantes { get; set; }
     //forma  pagamento:   
    }
}