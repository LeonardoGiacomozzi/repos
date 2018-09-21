using SIGI.Models.CadastroEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO
{
    public class EstadoDAO
    {
        public void Adiciona(Estado Estado)
        {
            using (var context = new SIGIContext())
            {
                context.Estado.Add(Estado);
                context.SaveChanges();
            }
        }

        public IList<Estado> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.Estado.ToList();
            }


        }

        public IList<Estado> BuscaPorPais(int PaisID) {

            IList<Estado> estadosBanco = Listar();
            IList<Estado> estadosRetorno = new List<Estado>();
            foreach (var estado in estadosBanco)
            {
                if (estado.PaisID==PaisID)
                {
                    estadosRetorno.Add(estado);
                }
            }
            return estadosRetorno;
        }
            
        public IList<Estado> ListarFullProperties()
        {
            var listaEstados = this.Listar();
            IList<Estado> result = new List<Estado>();
            foreach (var estado in listaEstados)
                result.Add(GetFullProperties(estado));
            return result;
        }
        public Estado GetFullProperties(Estado estado)
        {
            estado.Pais = new PaisDAO().BuscarPorId(estado.PaisID);
            return estado;
        }

        public Estado BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.Estado.Find(Id);

            }
        }

        public Estado BuscaUltimo()
        {
            using (var context = new SIGIContext())
            {
                return context.Estado.Last();

            }
        }

        public void Alterar(Estado Estado)
        {
            using (var context = new SIGIContext())
            {
                Estado estadoDoBanco = context.Estado.FirstOrDefault(e => e.Id == Estado.Id);
                estadoDoBanco.Nome = Estado.Nome;
                estadoDoBanco.PaisID = Estado.PaisID;
                context.SaveChanges();
            }


        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var estado = context.Estado.Find(id);
                context.Estado.Remove(estado);
                context.SaveChanges();

            }

        }
    }
}