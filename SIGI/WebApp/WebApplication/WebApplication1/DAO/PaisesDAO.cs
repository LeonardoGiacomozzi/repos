
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIGI.Models.CadastroEndereco;

namespace SIGI.DAO
{
    public class PaisDAO
    {

        public void Adiciona(Pais pais)
        {
            using (var context = new SIGIContext())
            {
                context.Pais.Add(pais);
                context.SaveChanges();
            }
        }

        public IList<Pais> Listar()
        {
            IList<Pais> paises = new List<Pais>();

            using (var context = new SIGIContext())
            {
                paises = context.Pais.ToList();
            }

            return paises;
        }

        public Pais BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.Pais.Find(Id);

            }
        }

        public Pais BuscaUltimo()
        {
            using (var context = new SIGIContext())
            {
                return context.Pais.Last();

            }
        }

        public void Alterar(Pais pais)
        {
            

            using (var context = new SIGIContext())
            {
                Pais paisDoBanco = context.Pais.FirstOrDefault(p => p.Id == pais.Id);
                paisDoBanco.Nome = pais.Nome;
                context.SaveChanges();
            }


        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var pais = context.Pais.Find(id);
                context.Pais.Remove(pais);
                context.SaveChanges();

            }
        }
    }
}