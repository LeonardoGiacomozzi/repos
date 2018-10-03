using SIGI.DAO.CadastroPesoa;
using SIGI.Models.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    public class PessoaFisicaController : Controller
    {
        // GET: PessoaFisica
        public ActionResult Adiciona(Pessoa pessoa)
        {
            PessoaDAO dao = new PessoaDAO();
            if (pessoa.ID == 0)
            {
                dao.Adiciona(pessoa);
            }
            else
            {
          
                dao.Alterar(pessoa);
            }


            return RedirectToAction("Index", "Pessoa");
        }

        public ActionResult Remover(int id)
        {
            PessoaDAO dao = new PessoaDAO();
            dao.Deletar(id);
            return RedirectToAction("Index", "Pessoa");
        }
    }
}