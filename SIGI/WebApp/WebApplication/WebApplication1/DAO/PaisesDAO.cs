using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGI.Models.CadastroEndereco;

namespace SIGI.DAO
{
    public class PaisesDAO
    {

        public void Adiciona(Paises pais)
        {
            using (var context = new SIGIContext())
            {
                context.Paises.Add(pais);
                context.SaveChanges();
            }
        }

        public IList<Paises> Listar()
        {
            IList<Paises> paises = new List<Paises>();

            using (var context = new SIGIContext())
            {
                paises = context.Paises.ToList();
            }

            return paises;
        }

        public Paises BuscarPorId (int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.Paises.Find(Id);

            }
        }

        public Paises BuscaUltimo()
        {
            using (var context = new SIGIContext())
            {
                return context.Paises.Last();

            }
        }

        public void Alterar(Paises pais)
        {
            using (var context = new SIGIContext()) 
            {
                context.Entry(pais).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var pais = context.Paises.Find(id);
                context.Paises.Remove(pais);
                context.SaveChanges();

            }
        }
    }
}