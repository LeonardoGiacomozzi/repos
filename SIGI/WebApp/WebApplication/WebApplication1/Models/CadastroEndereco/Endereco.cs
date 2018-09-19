

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGI.Models.CadastroEndereco
{
    public class Endereco
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string CEP { get; set; }
        public int Numero { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int CidadeID { get; set; }
        [ForeignKey("CidadeID")]
        [Required]
        public Cidade Cidade { get; set; }
        public int EstadoID { get; set; }
        [ForeignKey("EstadoID")]
        [Required]
        public Estado Estado { get; set; }
        public int PaisID { get; set; }
        [ForeignKey("PaisID")]
        [Required]
        public Pais Pais { get; set; }
        public string Complemento { get; set; }


    }
}