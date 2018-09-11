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
            PaisDAO paisDAO  = new PaisDAO();
            IList<Pais> Paises = paisDAO.Listar();
            ViewBag.paises= Paises;

            EstadoDAO estadoDAO= new EstadoDAO();
            IList<Estado> estado = estadoDAO.Listar();
            ViewBag.estados = estado;


            CidadeDAO cidadeDAO = new CidadeDAO();
            IList<Cidade> cidades= cidadeDAO.Listar();
            ViewBag.cidades = cidades;

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


        public ActionResult Alterar(Pais pais)
        {
            PaisDAO dao = new PaisDAO();
            Pais Pais = dao.BuscarPorId(pais.Id);
            Pais.Nome = (pais.Nome!=""? pais.Nome:Pais.Nome);
            dao.Alterar(Pais);
            return RedirectToAction("Index");
        }
    }
}