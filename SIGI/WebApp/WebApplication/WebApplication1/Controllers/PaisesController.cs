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
       

        public ActionResult Adiciona (Pais pais)
        {
            PaisDAO dao = new PaisDAO();
            if (pais.Id == 0)
            {
               dao.Adiciona(pais);
            }
            else
            {
                Pais Pais = dao.BuscarPorId(pais.Id);
                Pais.Nome = (pais.Nome != null ? pais.Nome : Pais.Nome);
                dao.Alterar(Pais);
            }
                 
           
            return RedirectToAction("Index", "Localidade");
        }

        public ActionResult Remover(int id)
        {
           PaisDAO dao = new PaisDAO();
           dao.Deletar(id);
           return RedirectToAction("Index", "Localidade");
        }
    }
}