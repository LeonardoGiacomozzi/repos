using SIGI.DAO.Usuarios;
using SIGI.Filtros;
using SIGI.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    [AutorizaFiltro]
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [FiltroAdm]
        public ActionResult Index()
        {
            ViewBag.usuarios = new UsuarioDAO().Listar();
           
            ViewBag.status = new UsuarioDAO().ListaStatos();
            return View();
        }
        public ActionResult NaoAdm()
        {
            
            return View();
        }

        public ActionResult Adiciona(Usuario usuario) {

            UsuarioDAO dao = new UsuarioDAO();

            if (usuario.ID== 0)
            {
                dao.Adiciona(usuario);
            }
            else
            {
                Usuario usuarioBanco = dao.BuscarPorId(usuario.ID);
                usuarioBanco.Login = (usuario.Login != null ? usuario.Login : usuarioBanco.Login);
                usuarioBanco.Senha = (usuario.Senha != null ? usuario.Senha : usuarioBanco.Senha);
                usuarioBanco.Status = usuario.Status;
                dao.Alterar(usuarioBanco);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id)
        {
            UsuarioDAO dao = new UsuarioDAO();
            dao.Deletar(id);
            return RedirectToAction("Index");
        }


    }
}