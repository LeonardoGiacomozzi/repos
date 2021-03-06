﻿using SIGI.DAO.CadastroPesoa;
using SIGI.Models.Atendimentos;
using SIGI.Models.Pessoas;
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
                atendimentoBanco.Resultado = atendimento.Resultado;

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

        public IList<Atendimento> ListaPorResultado(EResultado resutado)
        {
            IList<Atendimento> nova = new List<Atendimento>();
            var lista = Listar();

            foreach (var atendimento in lista)
            {
                if (atendimento.Resultado==resutado)
                {
                    nova.Add(atendimento);
                }
            }


            return nova;
        }

        public IList<Atendimento> ListaPorFuncionario(Pessoa pessoa)
        {
            IList<Atendimento> nova = new List<Atendimento>();
            var lista = Listar();

            foreach (var atendimento in lista)
            {
                if (atendimento.Funcionario == pessoa)
                {
                    nova.Add(atendimento);
                }
            }


            return nova;
        }

        public IList<Atendimento> ListaPorCliente(Pessoa pessoa)
        {
            IList<Atendimento> nova = new List<Atendimento>();
            var lista = Listar();

            foreach (var atendimento in lista)
            {
                if (atendimento.Cliente == pessoa)
                {
                    nova.Add(atendimento);
                }
            }


            return nova;
        }

        public List<Atendimento> ListaPorData(int total)
        {
            List<Atendimento> nova = new List<Atendimento>();
            var lista = Listar();
            total = 0 - total;
            foreach (var atendimento in lista)
            {
                if (atendimento.DataAtendimento>DateTime.Now.AddMonths(total))
                {
                    nova.Add(atendimento);
                }
            }

            

            return nova;
        }
        public List<Atendimento> ListaPorDataSemana(int total)
        {
            List<Atendimento> nova = new List<Atendimento>();
            var lista = Listar();
            total = 0 - total;
            foreach (var atendimento in lista)
            {
                if (atendimento.DataAtendimento > DateTime.Now.AddDays(total))
                {
                    nova.Add(atendimento);
                }
            }



            return nova;
        }


    }
}