using SIGI.DAO.CadastroImoveis;
using SIGI.Models.CadastroImovel.Valores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    public class ValorLocacaoController : Controller
    {
        public ActionResult Adiciona(ValorLocacao valor)
        {
            ValorLocacaoDAO locacaoDAO = new ValorLocacaoDAO();

            locacaoDAO.Adiciona(valor);

            return RedirectToAction("");
        }

        public ActionResult Altera(ValorLocacao valor)
        {
            ValorLocacaoDAO locacaoDAO = new ValorLocacaoDAO();

            locacaoDAO.Alterar(valor);

            return RedirectToAction("");
        }
        public ActionResult Renover(ValorLocacao valor)
        {
            ValorLocacaoDAO locacaoDAO = new ValorLocacaoDAO();

            locacaoDAO.Deletar(valor.ID);

            return RedirectToAction("");
        }
       
    }
}