using SIGI.Models.CadastroEndereco;
using SIGI.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    public class PaisesController : Controller
    {
        // GET: Paises
        public ActionResult Index()
        {
            PaisesDAO dao = new PaisesDAO();
            IList<Paises> Paises = dao.Listar(); 
            ViewBag.paises= Paises;
            return View();
        }

        public ActionResult Form()
        {
            
            return View();
        }
    }
}