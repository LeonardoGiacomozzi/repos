using System.Collections.Generic;
using SIGI.Models.Pessoas;

using SIGI.Models.CadastroImovel.ListaDetalhes;
using SIGI.Models.CadastroImovel.Caracteristicas;
using SIGI.Models.CadastroEndereco;
using SIGI.Models.CadastroImovel.Valores;

namespace SIGI.Models.CadastroImovel
{
    public class Imovel
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string DescricaoBreve { get; set; }
        public string DescricaoCompleta { get; set; }
        public ETipoNegocio TipoNegocio { get; set; }
        public EtipoDeImovel TipoDeImovel { get; set; }
        public EFinalidadeImovel Finalidade { get; set; }
        public int EnderecoID { get; set; }
        public Endereco Endereco { get; set; }
        public int ResponsavelID { get; set; }
        public Pessoa Responsavel { get; set; }
        public int CdgIntegracaoID { get; set; }
        public CodigoIntegracao CdgIntegracao { get; set; }
        public double MetragemUtil { get; set; }
        public double MetragemTotal{ get; set; }
        public IList<CaracteristicaPrincipal> CaracteristicasPrincipais { get; set; }
        public IList<CaracteristicasGerais> CaracteristicasGerais { get; set; }
        public int ValorID{ get; set; }
        public Valor Valor { get; set; }
        public int DetalhesID { get; set; }
        public Detalhes Detalhes { get; set; }
        
        public IList<Crm> Crm { get; set; }
       
    }
}