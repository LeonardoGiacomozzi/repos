using SIGI.DAO.CadastroImoveis;
using SIGI.Filtros;
using SIGI.Models.CadastroImovel.Caracteristicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    [AutorizaFiltroAttribute]
    public class CaracteristicasController : Controller
    {
        // GET: Caracteristicas
        public ActionResult Index()
        {
            CaracteristicaGeralDAO caracteristicasGerais = new CaracteristicaGeralDAO();
            CaracteristicasPricipaisDAO caracteristicasPricipais = new CaracteristicasPricipaisDAO();

            ViewBag.caracteristicasP = caracteristicasPricipais.Listar();

           


            ViewBag.tipoDado = caracteristicasPricipais.listaTipo();

            ViewBag.caracteristicasG = caracteristicasGerais.Listar();
         
            
            return View();
        }
        public ActionResult InsertPrincipal(CaracteristicaPrincipal caracteristica)
        {
            CaracteristicasPricipaisDAO dao = new CaracteristicasPricipaisDAO();
            if (caracteristica.ID == 0)
            {
                dao.Adiciona(caracteristica);
            }
            else
            {
                
                dao.Alterar(caracteristica);
            }


            return RedirectToAction("Index");
        }

        public ActionResult InsertGeral(CaracteristicasGerais caracteristica)
        {
            CaracteristicaGeralDAO dao = new CaracteristicaGeralDAO();
            if (caracteristica.ID == 0)
            {
                dao.Adiciona(caracteristica);
            }
            else
            {
                dao.Alterar(caracteristica);
            }


            return RedirectToAction("Index");
        }

        public ActionResult RemoverPrincipal(int id)
        {
            CaracteristicasPricipaisDAO dao = new CaracteristicasPricipaisDAO();
            dao.Deletar(id);
            return RedirectToAction("Index");
        }
        public ActionResult RemoverGeral(int id)
        {
            CaracteristicaGeralDAO dao = new CaracteristicaGeralDAO();
            dao.Deletar(id);
            return RedirectToAction("Index");
        }

    }
}