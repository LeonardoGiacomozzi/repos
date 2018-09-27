using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.Models.CadastroImovel.Caracteristicas
{
    public class CaracteristicaPrincipal : ICaracteristica
    {
        public ETipoDeDado  TipoDeDado { get; set; }
        public string Nome { get ; set ; }
        public string Valor { get ; set ; }
        public int ID { get;  set; }
        public bool Ativo { get; set; }

        public void Converte(ETipoDeDado tipo)
        {
            if (ETipoDeDado.Quantidade == tipo)
            {
                ConverteQuantidade();
            }
            else if (ETipoDeDado.Logico == tipo)
            {
                ConverteLogico();
            }
            else
            {
                ConverteData();
            }

        }

        public DateTime ConverteData()
        {
                       
            return Convert.ToDateTime(this.Valor);
        }

        public bool ConverteLogico()
        {
            if (this.Valor.Equals("Sim"))
            {
                return true;
            }
            return false;
        }

        public int ConverteQuantidade()
        {
            return Convert.ToInt32(this.Valor);
        }

     
    }
}