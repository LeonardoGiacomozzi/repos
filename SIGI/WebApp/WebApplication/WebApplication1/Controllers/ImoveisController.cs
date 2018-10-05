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

        public ActionResult Cadastro(int id) {

            ViewBag.atendimento = id;
            ViewBag.tipoNegocio = new ImovelDAO().ListaTipoNegocio();
            ViewBag.tipoDeImovel= new ImovelDAO().ListaTipoImovel();
            ViewBag.finalidade= new ImovelDAO().ListaFinalidadeNegocio();
            ViewBag.enderecos = new EnderecoDAO().ListarFullProperties();
            ViewBag.Pessoa = new PessoaDAO().ListaPorFuncao(ETipoPessoa.Cliente);
          
            return View();
        }

        public ActionResult Form(int id)
        {
            var imovel = new ImovelDAO().BuscarPorId(id);
            ViewBag.imovel = new ImovelDAO().GetFullPropriety(imovel);
            ViewBag.valor = new ValorVendaDAO().BuscarPorId(imovel.ValorID); 
            ViewBag.tipoNegocio = new ImovelDAO().ListaTipoNegocio();
            ViewBag.tipoDeImovel = new ImovelDAO().ListaTipoImovel();
            ViewBag.finalidade = new ImovelDAO().ListaFinalidadeNegocio();
            ViewBag.enderecos = new EnderecoDAO().ListarFullProperties();
            ViewBag.Pessoa = new PessoaDAO().ListaPorFuncao(ETipoPessoa.Cliente);
         
            return View();
        }

        public ActionResult Adiciona(Imovel imovel) {

            if (imovel.ID==0)
            {
              
              

                imovel.Valor.Tipo = imovel.TipoNegocio;

                new ImovelDAO().Adiciona(imovel);

            }
            else
            {
                imovel.Valor.Tipo = imovel.TipoNegocio;
                new ImovelDAO().Alterar(imovel);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id) {

            new ImovelDAO().Deletar(id);

            return RedirectToAction("Index");
        }

    }
}