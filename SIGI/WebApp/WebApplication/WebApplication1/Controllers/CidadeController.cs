﻿using SIGI.DAO;
using SIGI.Filtros;
using SIGI.Models.CadastroEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication1.Controllers

{
    [AutorizaFiltroAttribute]
    public class CidadeController : Controller
    {
        // GET: Cidade
        public ActionResult Adiciona(Cidade cidade)
        {

            CidadeDAO cidadeDAO = new CidadeDAO();
            
            if (cidade.ID == 0)
            {
                cidadeDAO.Adiciona(cidade);
            }
            else
            {
     
                cidadeDAO.Alterar(cidade);
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
