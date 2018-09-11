using SIGI.DAO;
using SIGI.Models.CadastroEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CidadeController : Controller
    {
        // GET: Cidade
        public ActionResult Adiciona(Cidade cidade)
        {

            CidadeDAO cidadeDAO = new CidadeDAO();
            cidadeDAO.Adiciona(cidade);

            return RedirectToAction("Index", "Paises");
        }

        public ActionResult Remover(int id)
        {
            CidadeDAO dao = new CidadeDAO();
            dao.Deletar(id);
            return RedirectToAction("Index", "Paises");
        }

      

        public ActionResult Alterar(Cidade cidade)
        {
            CidadeDAO dao = new CidadeDAO();
            Cidade Cidade = dao.BuscarPorId(cidade.ID);
            Cidade.Nome = (cidade.Nome!=null ? cidade.Nome : Cidade.Nome);
            Cidade.EstadoID = (cidade.EstadoID != 0 ? cidade.EstadoID : Cidade.EstadoID);
            dao.Alterar(Cidade);
            return RedirectToAction("Index", "Paises");
        }
    }
}
