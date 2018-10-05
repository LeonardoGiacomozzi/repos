using SIGI.DAO.Atendimentos;
using SIGI.Filtros;
using SIGI.Models;
using SIGI.Models.Atendimentos;
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

        public JsonResult Refresh() {

            var dash = new DashBoardInfos();

            dash.EstaSemana = UltimaSemana();
            dash.MesPassado = UltimosMes();
            dash.Ultimos12Meses = Ultimos12Meses();

            //dash.ListaPizzaFuncionario = ListaAtendimentosFuncionarios();

            return Json(dash);

        }

        public StatusConversaoAtendimento Ultimos12Meses() {

            var atendimentos = new AtendimentoDAO().ListaPorData(12);
            int totalConvettido = 0;
            foreach (var atendimento in atendimentos)
            {
                if (atendimento.Resultado==EResultado.Convertido)
                {
                    totalConvettido++;
                }
            }

            var total = atendimentos.Count();

            var porcentagem = (totalConvettido * 100) / total; 

            var resposta= new StatusConversaoAtendimento();

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

            var atendimentos = new AtendimentoDAO().ListaPorData(7);
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