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
            EstadoDAO estadoDAO = new EstadoDAO();
            IList<Estado> estados= estadoDAO.Listar();
            ViewBag.estados = estados;

            return View();
        }

        public ActionResult Form()
        {
            PaisDAO dao = new PaisDAO();
            IList<Pais> Paises = dao.Listar();
            ViewBag.paises= Paises;
            return View();
        }

        public ActionResult Adiciona(string nome, int id)
        {
            PaisDAO paisDAO= new PaisDAO();
            EstadoDAO estadoDAO = new EstadoDAO();
            Estado estado= new Estado();
            estado.Nome = nome;
            estado.Pais = paisDAO.BuscarPorId(id);
            estadoDAO.Adiciona(estado);

            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id)
        {
            EstadoDAO dao = new EstadoDAO();
            dao.Deletar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Selecionar()
        {
            EstadoDAO dao = new EstadoDAO();
            IList<Estado> estado = dao.Listar();
            ViewBag.estados= estado;
            return View();
        }

        public ActionResult Alterar(int id, string nome)
        {
            EstadoDAO dao = new EstadoDAO();
            Estado estado= dao.BuscarPorId(id);
            estado.Nome = nome;
            dao.Alterar(estado);
            return RedirectToAction("Index");
        }
    }
}
