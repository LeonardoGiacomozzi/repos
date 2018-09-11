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
            return RedirectToAction("Index", "Paises");
        }

        public ActionResult Adiciona(Estado estado)
        {
            
            EstadoDAO estadoDAO = new EstadoDAO();
            estadoDAO.Adiciona(estado);

            return RedirectToAction("Index", "Paises");
        }

        public ActionResult Remover(int id)
        {
            EstadoDAO dao = new EstadoDAO();
            dao.Deletar(id);
            return RedirectToAction("Index", "Paises");
        }

        public ActionResult Selecionar()
        {
            EstadoDAO dao = new EstadoDAO();
            IList<Estado> estado = dao.Listar();
            ViewBag.estados= estado;
            return View();
        }

        public ActionResult Alterar(Estado estado)
        {
            EstadoDAO dao = new EstadoDAO();
            Estado Estado= dao.BuscarPorId(estado.Id);
            Estado.Nome =(estado.Nome!=null ? estado.Nome : Estado.Nome);
            dao.Alterar(estado);
            return RedirectToAction("Index", "Paises");
        }
    }
}
