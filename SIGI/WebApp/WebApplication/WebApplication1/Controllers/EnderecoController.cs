using SIGI.DAO;
using SIGI.Models.CadastroEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    public class EnderecoController : Controller
    {

        public ActionResult Index()
        {
            EnderecoDAO enderecoDAO = new EnderecoDAO();
            ViewBag.endereco = enderecoDAO.ListarFullProperties();

            PaisDAO paisDAO = new PaisDAO();
            IList<Pais> Paises = paisDAO.Listar();
            ViewBag.paises = Paises;

            EstadoDAO estadoDAO = new EstadoDAO();
            IList<Estado> estado = estadoDAO.ListarFullProperties();
            ViewBag.estados = estado;


            CidadeDAO cidadeDAO = new CidadeDAO();
            IList<Cidade> cidades = cidadeDAO.ListarFullProperties();
            ViewBag.cidades = cidades;

            return View();
        }

        public ActionResult Insert(Endereco endereco)
        {
            EnderecoDAO dao = new EnderecoDAO();
            if (endereco.ID == 0)
            {
                dao.Adiciona(endereco);
            }
            else
            {

                dao.Alterar(endereco);
            }


            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id)
        {
            EnderecoDAO dao = new EnderecoDAO();
            dao.Deletar(id);
            return RedirectToAction("Index");
        }
    }
}