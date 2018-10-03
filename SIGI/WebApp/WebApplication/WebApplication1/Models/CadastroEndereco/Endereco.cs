

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGI.Models.CadastroEndereco
{
    public class Endereco
    {
       
        public int ID { get; set; }
        public string CEP { get; set; }
        public int Numero { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int CidadeID { get; set; }
      
        public Cidade Cidade { get; set; }
       
        public string Complemento { get; set; }


    }
}