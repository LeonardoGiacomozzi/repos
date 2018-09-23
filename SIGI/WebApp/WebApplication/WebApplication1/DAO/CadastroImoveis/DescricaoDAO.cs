using SIGI.Models.CadastroImovel.ListaDetalhes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO.CadastroImoveis
{
    public class DescricaoDAO
    {
        public void Adiciona(Detalhes detalhes)
        {
            using (var context = new SIGIContext())
            {
                context.Detalhes.Add(detalhes);
                context.SaveChanges();
            }
        }

        public IList<Detalhes> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.Detalhes.ToList();
            }


        }



        public Detalhes BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.Detalhes.Find(Id);

            }
        }

        public Detalhes BuscaUltimo()
        {
            using (var context = new SIGIContext())
            {
                return context.Detalhes.Last();

            }
        }

        public void Alterar(Detalhes detalhes)
        {


            using (var context = new SIGIContext())
            {
                Detalhes detalhesbanco = context.Detalhes.FirstOrDefault(d => d.ID == detalhes.ID);
                detalhesbanco.Descricao = detalhes.Descricao;

                context.SaveChanges();
            }


        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var detalhes = context.Detalhes.Find(id);
                context.Detalhes.Remove(detalhes);
                context.SaveChanges();

            }
        }
    }
}