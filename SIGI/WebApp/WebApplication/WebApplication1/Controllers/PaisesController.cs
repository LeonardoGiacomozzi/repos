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
            PaisDAO dao = new PaisDAO();
            IList<Pais> Paises = dao.Listar();
            ViewBag.paises= Paises;
            return View();
        }

        public ActionResult Form()
        {
            
            return View();
        }

        public ActionResult Adiciona (Pais pais)
        {
           
                PaisDAO dao = new PaisDAO();
                 dao.Adiciona(pais);
           
            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id)
        {
           PaisDAO dao = new PaisDAO();
           dao.Deletar(id);
           return RedirectToAction("Index");
        }

        public ActionResult Selecionar()
        {
            PaisDAO dao = new PaisDAO();
            IList<Pais> pais = dao.Listar();
            ViewBag.paises = pais;
            return View();
        }

        public ActionResult Alterar(int id ,string nome)
        {
            PaisDAO dao = new PaisDAO();
            Pais pais = dao.BuscarPorId(id);
            pais.Nome = nome;
            dao.Alterar(pais);
            return RedirectToAction("Index");
        }
    }
}