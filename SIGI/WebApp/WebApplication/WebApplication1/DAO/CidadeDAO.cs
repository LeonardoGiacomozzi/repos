using SIGI.Models.CadastroEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO
{
    public class CidadeDAO
    {
        public void Adiciona(Cidade Cidade)
        {
            using (var context = new SIGIContext())
            {
                context.Cidade.Add(Cidade);
                context.SaveChanges();
            }
        }

        public IList<Cidade> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.Cidade.ToList();
            }


        }

        public IList<Cidade> ListarFullProperties()
        {
            var listaEstados = this.Listar();
            IList<Cidade> result = new List<Cidade>();
            foreach (var cidade in listaEstados)
                result.Add(GetFullProperties(cidade));
            return result;
        }
        public Cidade GetFullProperties(Cidade cidade)
        {
            cidade.Estado= new EstadoDAO().BuscarPorId(cidade.EstadoID);
            return cidade;
        }


        public Cidade BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.Cidade.Find(Id);

            }
        }

        public Cidade BuscaUltimo()
        {
            using (var context = new SIGIContext())
            {
                return context.Cidade.Last();

            }
        }

        public void Alterar(Cidade Cidade)
        {
            //using (var context = new SIGIContext())
            //{
            //    context.Entry(pais).State = EntityState.Modified;
            //    context.SaveChanges();
            //}

            using (var context = new SIGIContext())
            {
                Cidade cidadeDoBanco = context.Cidade.FirstOrDefault(e => e.ID == Cidade.ID);
                cidadeDoBanco.Nome = Cidade.Nome;
                cidadeDoBanco.EstadoID= Cidade.EstadoID;
                context.SaveChanges();
            }


        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var cidade = context.Cidade.Find(id);
                context.Cidade.Remove(cidade);
                context.SaveChanges();

            }

        }
    }
}
