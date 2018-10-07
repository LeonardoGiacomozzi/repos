using SIGI.DAO.Atendimentos;
using SIGI.DAO.CadastroImoveis;
using SIGI.DAO.CadastroPesoa;
using SIGI.Filtros;
using SIGI.Models;
using SIGI.Models.Atendimentos;
using SIGI.Models.CadastroImovel;
using SIGI.Models.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGI.Controllers
{
    [AutorizaFiltro]
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Refresh()
        {

            var dash = new DashBoardInfos();

            dash.EstaSemana = UltimaSemana();
            dash.MesPassado = UltimosMes();
            dash.Ultimos12Meses = Ultimos12Meses();

            dash.ListaPizzaFuncionario = ListaAtendimentosFuncionarios();
            dash.ListaPizzaValor = ListaRendimentoFuncionarios();

            return Json(dash);

        }

        private List<PizzaFuncionarioInfo> ListaAtendimentosFuncionarios()
        {
            var atendimentos = new AtendimentoDAO().ListaPorData(1);
            var funcionarios = new PessoaDAO().ListaPorFuncao(ETipoPessoa.Funcionario);
            var lista = new List<PizzaFuncionarioInfo>();
            foreach (var funcionario in funcionarios)
            {
                var convertido = 0;
                foreach (var atendimento in atendimentos)
                {
                    if (funcionario.ID == atendimento.FuncionarioID)
                    {
                        if (atendimento.Resultado == EResultado.Convertido)
                        {
                            convertido++;
                        }
                    }
                }

                var percentual = (convertido * 100) / atendimentos.Count;

                lista.Add(new PizzaFuncionarioInfo(funcionario.Nome, percentual));
            }

            return lista;
        }

        private List<PizzaFuncionarioInfo> ListaRendimentoFuncionarios()
        {
            var atendimentos = new AtendimentoDAO().ListaPorData(1);
            var imoveis = new ImovelDAO().ListarImoveisDeAtendimento();
            var funcionarios = new PessoaDAO().ListaPorFuncao(ETipoPessoa.Funcionario);
            var lista = new List<PizzaFuncionarioInfo>();
            double valorTotal = 0;
            foreach (var imovel in imoveis) {
                if (imovel.TipoNegocio == ETipoNegocio.Locação)
                {
                    valorTotal += imovel.Valor.Comissao * 12.0;
                }
                else
                {
                    valorTotal += imovel.Valor.Comissao;
                }
            }
            foreach (var funcionario in funcionarios)
            {

                double valorFuncionario = 0;

                foreach (var imovel in imoveis)
                {
                    if (imovel.Atendimento.FuncionarioID == funcionario.ID)
                    {

                        if (imovel.TipoNegocio == ETipoNegocio.Locação)
                        {
                            valorFuncionario += imovel.Valor.Comissao * 12.0;
                        }
                        else
                        {
                            valorFuncionario += imovel.Valor.Comissao;
                        }
                    }
                }
                
                var percentual = (valorFuncionario * 100) / valorTotal;

                lista.Add(new PizzaFuncionarioInfo(funcionario.Nome, percentual));
            }
            
            return lista;
        }

        public StatusConversaoAtendimento Ultimos12Meses()
        {

            var atendimentos = new AtendimentoDAO().ListaPorData(12);
            int totalConvettido = 0;
            foreach (var atendimento in atendimentos)
            {
                if (atendimento.Resultado == EResultado.Convertido)
                {
                    totalConvettido++;
                }
            }

            var total = atendimentos.Count();

            var porcentagem = (totalConvettido * 100) / total;

            var resposta = new StatusConversaoAtendimento();

            resposta.Percentual = porcentagem;
            resposta.Descricao = "Atendimentos convertidos dos últimos 12 meses";

            return resposta;
        }

        public StatusConversaoAtendimento UltimosMes()
        {

            var atendimentos = new AtendimentoDAO().ListaPorData(1);
            int totalConvettido = 0;
            foreach (var atendimento in atendimentos)
            {
                if (atendimento.Resultado == EResultado.Convertido)
                {
                    totalConvettido++;
                }
            }

            var total = atendimentos.Count();

            var porcentagem = (totalConvettido * 100) / total;

            var resposta = new StatusConversaoAtendimento();

            resposta.Percentual = porcentagem;
            resposta.Descricao = "Atendimentos convertidos do último mês";

            return resposta;
        }

        public StatusConversaoAtendimento UltimaSemana()
        {

            var atendimentos = new AtendimentoDAO().ListaPorDataSemana(7);
            int totalConvettido = 0;
            foreach (var atendimento in atendimentos)
            {
                if (atendimento.Resultado == EResultado.Convertido)
                {
                    totalConvettido++;
                }
            }

            var total = atendimentos.Count();

            var porcentagem = (totalConvettido * 100) / total;

            var resposta = new StatusConversaoAtendimento();

            resposta.Percentual = porcentagem;
            resposta.Descricao = "Atendimentos convertidos da última semana";

            return resposta;
        }
    }
}