namespace SIGI.Models.CadastroImovel
{
    public class CodigoIntegracao
    {
        public int ID { get; set; }
        public string Origem { get; set; }
        public string Codigo { get; set; }

        public override string ToString()
        {
            return Origem + "-"+Codigo;
        }
    }
   
}