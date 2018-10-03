using SIGI.DAO;
using SIGI.DAO.CadastroImoveis;
using SIGI.DAO.CadastroPesoa;
using SIGI.Filtros;
using SIGI.Models.CadastroImovel;
using SIGI.Models.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    [AutorizaFiltro]
    public class ImoveisController : Controller
    {
        // GET: Imoveis
        public ActionResult Index()
        {
            ImovelDAO imovelDAO = new ImovelDAO();
            ViewBag.imoveis = imovelDAO.ListarFullPropriety();
            return View();
        }

        public ActionResult Cadastro() {

            ViewBag.tipoNegocio = new ImovelDAO().ListaTipoNegocio();
            ViewBag.tipoDeImovel= new ImovelDAO().ListaTipoImovel();
            ViewBag.finalidade= new ImovelDAO().ListaFinalidadeNegocio();
            ViewBag.enderecos = new EnderecoDAO().ListarFullProperties();
            ViewBag.Pessoa = new PessoaDAO().ListaPorFuncao(ETipoPessoa.Cliente);
            ViewBag.caracteristicasP = new CaracteristicasPricipaisDAO().ListarAtivos();
            ViewBag.caracteristicasG = new CaracteristicaGeralDAO().ListarAtivos();
            ViewBag.tipoDado = new CaracteristicasPricipaisDAO().listaTipo();
            return View();
        }

        public ActionResult Form(int id)
        {
            var imovel = new ImovelDAO().BuscarPorId(id);
            ViewBag.imovel = new ImovelDAO().GetFullPropriety(imovel);
            ViewBag.tipoNegocio = new ImovelDAO().ListaTipoNegocio();
            ViewBag.tipoDeImovel = new ImovelDAO().ListaTipoImovel();
            ViewBag.finalidade = new ImovelDAO().ListaFinalidadeNegocio();
            ViewBag.enderecos = new EnderecoDAO().ListarFullProperties();
            ViewBag.Pf = new PessoaDAO().ListarFullProperties();
         
            return View();
        }

        public ActionResult Adiciona(Imovel imovel) {



            new CdgIntegracaoDAO().Adiciona(imovel.CdgIntegracao);
            var codigo = new CdgIntegracaoDAO().BuscarPorCDG(imovel.CdgIntegracao.Codigo);
            imovel.CdgIntegracaoID = codigo.ID;
            new ImovelDAO().Adiciona(imovel);

            return RedirectToAction("Index");
        }

    }
}