using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.Models
{
    public class PizzaFuncionarioInfo
    {
        public string NomeFuncionario { get; set; }
        public double Percentual { get; set; }
       
        public PizzaFuncionarioInfo(string nome,double percentual)
        {

            this.NomeFuncionario = nome;
            this.Percentual = percentual;
        } 
    }
}