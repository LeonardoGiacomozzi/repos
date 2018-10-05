using SIGI.DAO.Atendimentos;
using SIGI.DAO.CadastroPesoa;
using SIGI.Filtros;
using SIGI.Models.Atendimentos;
using SIGI.Models.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
   

    [AutorizaFiltro]
    public class AtendimentoController : Controller
    {
        // GET: Atendimento
        public ActionResult Index()
        {
            ViewBag.atendimentos = new AtendimentoDAO().ListarFullProperties();
            ViewBag.pendente = EResultado.Pendente;
            ViewBag.convertido = EResultado.Convertido;
            return View();
        }

        public ActionResult Criar()
        {
            ViewBag.funcionarios = new PessoaDAO().ListaPorFuncao(ETipoPessoa.Funcionario);
            ViewBag.clientes = new PessoaDAO().ListaPorFuncao(ETipoPessoa.Cliente);
            
            ViewBag.naoConvertido = EResultado.NaoConvertido;
            return View();
        }
        public ActionResult Adicionar(Atendimento atendimento)
        {
            if (atendimento.ID == 0)
            {
                new AtendimentoDAO().Adiciona(atendimento);

            }
            else
            {
                new AtendimentoDAO().Alterar(atendimento);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Remover(int id) {

            new AtendimentoDAO().Deletar(id);

            return RedirectToAction("Index");
        }


        public ActionResult Editar(int id)
        {


            ViewBag.atendimento = new AtendimentoDAO().BuscarPorId(id);
            ViewBag.funcionarios = new PessoaDAO().ListaPorFuncao(ETipoPessoa.Funcionario);
            ViewBag.clientes = new PessoaDAO().ListaPorFuncao(ETipoPessoa.Cliente);

            return View();
        }

        public ActionResult Converter(int id) {

            var atendimento = new AtendimentoDAO().BuscarPorId(id);
            atendimento.Resultado = EResultado.Convertido;
            new AtendimentoDAO().Alterar(atendimento);
            return RedirectToAction("Index");
        }
        public ActionResult NaoConverter(int id) {

            var atendimento = new AtendimentoDAO().BuscarPorId(id);
            atendimento.Resultado = EResultado.NaoConvertido;
            new AtendimentoDAO().Alterar(atendimento);
            return RedirectToAction("Index");
        }

    }
}