using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.Models
{
    public class DashBoardInfos
    {
        public StatusConversaoAtendimento Ultimos12Meses { get; set; }
        public StatusConversaoAtendimento MesPassado { get; set; }
        public StatusConversaoAtendimento EstaSemana { get; set; }

        public List<PizzaFuncionarioInfo> ListaPizzaFuncionario { get; set; }
        public List<PizzaFuncionarioInfo> ListaPizzaValor { get; set; }
    }
}