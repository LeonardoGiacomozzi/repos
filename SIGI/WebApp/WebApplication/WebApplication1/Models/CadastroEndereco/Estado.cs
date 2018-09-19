using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SIGI.Models.CadastroEndereco
{
    public class Estado
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int PaisID { get; set; }
        [ForeignKey("PaisID")]
        [Required]
        public Pais Pais { get; set; }
        public string  Nome { get; set; }
      
        public override string ToString()
        {
            return this.Nome;
        }
    }
}