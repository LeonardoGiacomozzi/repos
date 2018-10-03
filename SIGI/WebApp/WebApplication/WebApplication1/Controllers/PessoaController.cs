using SIGI.DAO;
using SIGI.DAO.CadastroPesoa;
using SIGI.Filtros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    [AutorizaFiltro]
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
           
            ViewBag.pessoa = new PessoaDAO().ListarFullProperties();
            ViewBag.tipoPessoa = new PessoaDAO().ListaTipoPessoa();
            ViewBag.enderecos = new EnderecoDAO().ListarFullProperties();
            ViewBag.estadoCivil = new PessoaDAO().ListaEstadoCIvil();
            ViewBag.pessoatipo = new PessoaDAO().ListaPessoa();
            return View();
        }
    }
}