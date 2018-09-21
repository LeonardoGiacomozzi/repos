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
            if (cidade.ID == 0)
            {
                cidadeDAO.Adiciona(cidade);
            }
            else
            {
                Cidade Cidade = cidadeDAO.BuscarPorId(cidade.ID);
                Cidade.Nome = (cidade.Nome != null ? cidade.Nome : Cidade.Nome);
                cidadeDAO.Alterar(Cidade);
            }
            return RedirectToAction("Index", "Localidade");
        }

        public ActionResult Remover(int id)
        {
            CidadeDAO dao = new CidadeDAO();
            dao.Deletar(id);
            return RedirectToAction("Index", "Localidade");
        }
    }
}
