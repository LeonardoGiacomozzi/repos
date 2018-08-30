using SIGI.DAO;
using SIGI.Models.CadastroEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    public class EstadoController : Controller
    {
        // GET: Estado
        public ActionResult Index()
        {
            EstadoDAO dao = new EstadoDAO();
            IList<Estado> estados= dao.Listar();
            ViewBag.estados = estados;

            return View();
        }
    }
}