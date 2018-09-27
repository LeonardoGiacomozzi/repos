using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGI.Models.Pessoas;

using SIGI.Models.CadastroImovel.ListaDetalhes;
using WebApplication1.Models.CadastroImovel;
using WebApplication1.Models.CadastroImovel.ListaDocumentos;
using SIGI.Models.CadastroImovel.Caracteristicas;
using SIGI.Models.CadastroEndereco;
using SIGI.Models.CadastroImovel.Valores;

namespace SIGI.Models.CadastroImovel
{
    public class Imovel
    {
        public int ID { get; set; }
        private string Codigo { get; set; }
        public string DescricaoBreve { get; set; }
        public string DescricaoCompleta { get; set; }
        public ETipoNegocio TipoNegocio { get; set; }
        public EtipoDeImovel TipoDeImovel { get; set; }
        public EFinalidadeImovel Finalidade { get; set; }
        public Endereco Endereco { get; set; }
        public Pessoa Responsavel { get; set; }
        public CodigoIntegracao CdgIntegracao { get; set; }
        public double MetragemUtil { get; set; }
        public double MetragemTotal{ get; set; }
        public IList<CaracteristicaPrincipal> CaracteristicasPrincipais { get; set; }
        public IList<CaracteristicasGerais> CaracteristicasGerais { get; set; }
        public ValorVenda ValorDeVenda { get; set; }
        public ValorLocacao ValorLocacao { get; set; }
        public Detalhes Detalhes { get; set; }
        public IList<Anexo> Anexos { get; set; }
        public IList<Crm> Crm { get; set; }
        public IList<Documentos> Documentos { get; set; }
    }
}