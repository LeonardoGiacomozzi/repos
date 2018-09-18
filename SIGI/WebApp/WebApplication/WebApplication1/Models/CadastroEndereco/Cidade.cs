using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.Models.CadastroEndereco
{
    public class Cidade
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int EstadoID { get; set; }
        public Estado Estado { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}