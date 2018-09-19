using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SIGI.Models.CadastroEndereco
{
    public class Cidade
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Nome { get; set; }
        public int EstadoID { get; set; }
        [ForeignKey("EstadoID")]
        [Required]
        public Estado Estado { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}