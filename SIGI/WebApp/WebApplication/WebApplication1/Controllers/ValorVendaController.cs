﻿using SIGI.DAO.CadastroImoveis;
using SIGI.Models.CadastroImovel.Valores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    public class ValorVendaController : Controller
    {
       
        public ActionResult Adiciona(ValorVenda valor)
        {
            ValorVendaDAO vendaDAO = new ValorVendaDAO();
            
            vendaDAO.Adiciona(valor);
           
            return RedirectToAction("");
        }

        public ActionResult Altera(ValorVenda valor)
        {
            ValorVendaDAO vendaDAO = new ValorVendaDAO();

            vendaDAO.Alterar(valor);

            return RedirectToAction("");
        }
        public ActionResult Renover(ValorVenda valor)
        {
            ValorVendaDAO vendaDAO = new ValorVendaDAO();

            vendaDAO.Deletar(valor.ID);

            return RedirectToAction("");
        }
       

    }
}