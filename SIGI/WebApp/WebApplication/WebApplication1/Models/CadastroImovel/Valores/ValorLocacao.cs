namespace SIGI.Models.CadastroImovel.Valores
{
    public abstract class ValorLocacao:IValor
    {
        public int ID { get; set; }
        public double IPTU { get; set; }
        public double Condominio { get; set; }
        public double Mensalidade { get; set; }
        public string DescricaoPagamento { get; set; }

        
    }
}