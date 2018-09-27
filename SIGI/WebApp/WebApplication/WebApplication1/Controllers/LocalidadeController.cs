using SIGI.DAO;
using SIGI.Filtros;
using SIGI.Models.CadastroEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    [AutorizaFiltroAttribute]
    public class LocalidadeController : Controller
    {
        // GET: Localidade
        public ActionResult Index()
        {
            PaisDAO paisDAO = new PaisDAO();
            IList<Pais> Paises = paisDAO.Listar();
            ViewBag.paises = Paises;

            EstadoDAO estadoDAO = new EstadoDAO();
            IList<Estado> estado = estadoDAO.ListarFullProperties();
            ViewBag.estados = estado;


            CidadeDAO cidadeDAO = new CidadeDAO();
            IList<Cidade> cidades = cidadeDAO.ListarFullProperties();
            ViewBag.cidades = cidades;

            return View();
        }
    }
}