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

        public ActionResult Adiciona (string nome)
        {
           
                PaisesDAO dao = new PaisesDAO();
                Paises pais = new Paises();
                pais.Nome = nome;
                dao.Adiciona(pais);
           
            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id)
        {
           PaisesDAO dao = new PaisesDAO();
           dao.Deletar(id);
           return RedirectToAction("Index");
        }

        public ActionResult Selecionar()
        {
            PaisesDAO dao = new PaisesDAO();
            IList<Paises> pais = dao.Listar();
            ViewBag.paises = pais;
            return View();
        }

        public ActionResult Alterar(int id ,string nome)
        {
            PaisesDAO dao = new PaisesDAO();
            Paises pais = dao.BuscarPorId(id);
            pais.Nome = nome;
            dao.Alterar(pais);
            return RedirectToAction("Index");
        }
    }
}