using SIGI.DAO.CadastroPesoa;
using SIGI.Models.Atendimentos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace SIGI.DAO.Atendimentos
{
    public class AtendimentoDAO
    {

        public void Adiciona(Atendimento atendimento)
        {
            using (var context = new SIGIContext())
            {
                atendimento.DataAtendimento = (atendimento.DataAtendimento.ToString() == "01/01/0001 00:00:00" ? DateTime.Now : atendimento.DataAtendimento);
                context.Atendimento.Add(atendimento);
                context.SaveChanges();
            }
        }

        public IList<Atendimento> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.Atendimento.ToList();
            }


        }



        public Atendimento BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.Atendimento.Find(Id);

            }
        }

        public IList<Atendimento> ListarFullProperties()
        {
            var listaAtendimento = this.Listar();
            IList<Atendimento> result = new List<Atendimento>();
            foreach (var atendimento in listaAtendimento)
                result.Add(GetFullProperties(atendimento));
            return result;
        }
        public Atendimento GetFullProperties(Atendimento atendimento)
        {
            atendimento.Cliente =new PessoaDAO().BuscarPorId(atendimento.ClienteID);
            atendimento.Funcionario =new PessoaDAO().BuscarPorId(atendimento.FuncionarioID);

            //string format = "dd/mm/yyyy";

            //DateTime dateTime = DateTime.ParseExact(atendimento.DataAtendimento.ToString(), format,
            //    CultureInfo.CreateSpecificCulture("Brasil"));


            return atendimento;
        }

        public void Alterar(Atendimento atendimento)
        {


            using (var context = new SIGIContext())
            {
                Atendimento atendimentoBanco = context.Atendimento.FirstOrDefault(a => a.ID == atendimento.ID);
                atendimentoBanco.ClienteID = (atendimento.ClienteID!=0? atendimento.ClienteID: atendimentoBanco.ClienteID);
                atendimentoBanco.FuncionarioID = (atendimento.FuncionarioID!=0? atendimento.FuncionarioID: atendimentoBanco.FuncionarioID);
                atendimentoBanco.Relatorio = (atendimento.Relatorio!=null? atendimento.Relatorio: atendimentoBanco.Relatorio);
                atendimentoBanco.Nome = (atendimento.Nome!=null? atendimento.Nome: atendimentoBanco.Nome);
                atendimentoBanco.Resultado = atendimentoBanco.Resultado;

                context.SaveChanges();
            }


        }
        public IList<EResultado> ListaResultados() {
            var lista = new List<EResultado>();
            lista.Add(EResultado.Pendente);
            lista.Add(EResultado.Convertido);
            lista.Add(EResultado.NaoConvertido);

            return lista;

        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var atendimento = context.Atendimento.Find(id);
                context.Atendimento.Remove(atendimento);
                context.SaveChanges();

            }
        }
    }
}