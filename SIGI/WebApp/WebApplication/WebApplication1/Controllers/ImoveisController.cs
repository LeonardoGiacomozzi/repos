using SIGI.DAO.CadastroImoveis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    public class ImoveisController : Controller
    {
        // GET: Imoveis
        public ActionResult Index()
        {
            ImovelDAO imovelDAO = new ImovelDAO();
            ViewBag.imoveis = imovelDAO.Listar();
            return View();
        }
    }
}