﻿using SIGI.DAO;
using SIGI.Filtros;
using SIGI.Models.CadastroEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    [AutorizaFiltroAttribute]
    public class EstadoController : Controller
    {
        public ActionResult Adiciona(Estado estado)
        {
            
           
            EstadoDAO estadoDAO = new EstadoDAO();
            
            if (estado.Id == 0)
            {
                estadoDAO.Adiciona(estado);
            }
            else
            {
                
                estadoDAO.Alterar(estado);
            }

            return RedirectToAction("Index", "Localidade");
        }

        public ActionResult Remover(int id)
        {
            EstadoDAO dao = new EstadoDAO();
            dao.Deletar(id);
            return RedirectToAction("Index", "Localidade");
        }
    }
}
