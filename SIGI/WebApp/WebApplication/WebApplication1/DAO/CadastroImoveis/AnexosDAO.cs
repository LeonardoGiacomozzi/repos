using SIGI.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.CadastroImovel;

namespace WebApplication1.DAO.CadastroImoveis
{
    public class AnexosDAO
    {
        public void Adiciona(Anexo anexo)
        {
            using (var context = new SIGIContext())
            {
                context.Anexo.Add(anexo);
                context.SaveChanges();
            }
        }

        public IList<Anexo> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.Anexo.ToList();
            }


        }



        public Anexo BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.Anexo.Find(Id);

            }
        }

        public Anexo BuscaUltimo()
        {
            using (var context = new SIGIContext())
            {
                return context.Anexo.Last();

            }
        }

        public void Alterar(Anexo anexo)
        {
            //using (var context = new SIGIContext())
            //{
            //    context.Entry(pais).State = EntityState.Modified;
            //    context.SaveChanges();
            //}

            using (var context = new SIGIContext())
            {
                Anexo anexoDoBanco = context.Anexo.FirstOrDefault(a => a.ID == anexo.ID);
                anexoDoBanco.Nome = anexo.Nome;

                context.SaveChanges();
            }


        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var anexo = context.Anexo.Find(id);
                context.Anexo.Remove(anexo);
                context.SaveChanges();

            }
        }
    }
}