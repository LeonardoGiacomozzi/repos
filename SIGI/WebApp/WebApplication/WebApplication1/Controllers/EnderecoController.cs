using SIGI.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    public class EnderecoController : Controller
    {
       
        public ActionResult Index()
        {
            EnderecoDAO enderecoDAO = new EnderecoDAO();
            ViewBag.endereco = enderecoDAO.ListarFullProperties();

            return View();
        }

        public ActionResult Insert()
        {

            return RedirectToAction("Index");
        }
    }
}