using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGI.Models.Pessoas;

using SIGI.Models.CadastroImovel.ListaDetalhes;
using WebApplication1.Models.CadastroImovel.Valores;
using WebApplication1.Models.CadastroImovel;
using WebApplication1.Models.CadastroImovel.ListaDocumentos;
using SIGI.Models.CadastroImovel.Caracteristicas;
using SIGI.Models.CadastroEndereco;

namespace SIGI.Models.CadastroImovel
{
    public class Imovel
    {
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
        public IList<ICaracteristica> CaracteristicasPrincipais { get; set; }
        public IList<ICaracteristica> CaracteristicasGerais { get; set; }
        public Valor ValorTotal { get; set; }
        public Detalhes Detalhes { get; set; }
        public IList<Anexo> Anexos { get; set; }
        public Crm Crm { get; set; }
        public IList<Documentos> Documentos { get; set; }
    }
}