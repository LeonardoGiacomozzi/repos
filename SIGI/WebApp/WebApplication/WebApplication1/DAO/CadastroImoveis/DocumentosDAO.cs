using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.CadastroImovel.ListaDocumentos;

namespace SIGI.DAO.CadastroImoveis
{
    public class DocumentosDAO
    {
        public void Adiciona(Documentos documentos)
        {
            using (var context = new SIGIContext())
            {
                context.Documentos.Add(documentos);
                context.SaveChanges();
            }
        }

        public IList<Documentos> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.Documentos.ToList();
            }


        }



        public Documentos BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.Documentos.Find(Id);

            }
        }

        public Documentos BuscaUltimo()
        {
            using (var context = new SIGIContext())
            {
                return context.Documentos.Last();

            }
        }

        public void Alterar(Documentos documentos)
        {


            using (var context = new SIGIContext())
            {
                Documentos documentosDoBanco = context.Documentos.FirstOrDefault(d => d.ID == documentos.ID);
                documentosDoBanco.Tipo = documentos.Tipo;
                documentosDoBanco.DataDeAlteração = DateTime.Now;

                context.SaveChanges();
            }


        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var documentos = context.Documentos.Find(id);
                context.Documentos.Remove(documentos);
                context.SaveChanges();

            }
        }


    }
}