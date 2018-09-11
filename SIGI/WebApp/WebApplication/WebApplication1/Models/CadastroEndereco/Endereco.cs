

namespace SIGI.Models.CadastroEndereco
{
    public class Endereco
    {
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public Estado Estado { get; set; }
        public Pais Pais { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }

    }
}