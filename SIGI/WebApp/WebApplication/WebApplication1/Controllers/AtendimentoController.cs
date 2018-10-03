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
            return View();
        }

        public ActionResult Criar()
        {
            ViewBag.funcionarios = new PessoaDAO().ListaPorFuncao(ETipoPessoa.Funcionario);
            ViewBag.clientes = new PessoaDAO().ListaPorFuncao(ETipoPessoa.Cliente);
            ViewBag.pendente = EResultado.Pendente;
            ViewBag.convertido = EResultado.Convertido;
            ViewBag.naoConvertido = EResultado.NaoConvertido;
            return View();
        }
        public ActionResult Adicionar(Atendimento atendimento)
        {
           
            new AtendimentoDAO().Adiciona(atendimento);

            if (atendimento.Resultado== EResultado.Convertido)
            {
            return RedirectToAction("Cadastro","Imoveis");

            }

            return RedirectToAction("Index");
        }

    }
}