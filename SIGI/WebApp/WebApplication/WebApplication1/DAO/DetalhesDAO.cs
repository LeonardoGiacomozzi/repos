using SIGI.Models.CadastroImovel.ListaDetalhes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO
{
    public class DetalhesDAO
    {

        public void Adiciona(Detalhes detalhe)
        {
            using (var context = new SIGIContext())
            {
                context.Detalhes.Add(detalhe);
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

        

        public void Alterar(Detalhes detalhe)
        {


            using (var context = new SIGIContext())
            {
                Detalhes detalhesDoBanco = context.Detalhes.FirstOrDefault(d => d.ID == detalhe.ID);
                detalhesDoBanco.Descricao = detalhesDoBanco.Descricao;

                context.SaveChanges();
            }


        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var detalhe = context.Detalhes.Find(id);
                context.Detalhes.Remove(detalhe);
                context.SaveChanges();

            }
        }
    }
}