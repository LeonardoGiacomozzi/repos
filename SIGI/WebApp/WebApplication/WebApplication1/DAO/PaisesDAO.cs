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
            using (var context = new SIGIContext())
            {
                return context.Paises.ToList();
            }
        }

        public Paises BuscarPorId (int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.Paises.Find(Id);

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