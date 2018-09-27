using SIGI.DAO.Usuarios;
using SIGI.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Autenticar(Usuario usuario)
        {

            UsuarioDAO usuarioDAO = new UsuarioDAO();

            Usuario usuarioBanco = usuarioDAO.Buscar(usuario);

            if (usuarioBanco != null) 
            {
                Session["UsuarioLogado"] = usuarioBanco;
                return RedirectToAction("Index", "Endereco");
            }
            return RedirectToAction("Index");


        }


    }
}