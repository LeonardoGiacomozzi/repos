using SIGI.Models.CadastroImovel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO.CadastroImoveis
{
    public class CdgIntegracaoDAO
    {

        public void Adiciona(CodigoIntegracao cdg)
        {
            using (var context = new SIGIContext())
            {
                context.CodigoIntegracao.Add(cdg);
                context.SaveChanges();
            }
        }

        public IList<CodigoIntegracao> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.CodigoIntegracao.ToList();
            }


        }



        public CodigoIntegracao BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.CodigoIntegracao.Find(Id);

            }
        }

        public CodigoIntegracao BuscarPorCDG(string cdg)
        {
            using (var context = new SIGIContext())
            {
                return context.CodigoIntegracao.FirstOrDefault(c => c.Codigo == cdg); ;

            }
        }
        public void Alterar(CodigoIntegracao cdg)
        {


            using (var context = new SIGIContext())
            {
                CodigoIntegracao crmDoBanco = context.CodigoIntegracao.FirstOrDefault(c => c.Codigo == cdg.Codigo);
                crmDoBanco.Codigo = cdg.Codigo;
                crmDoBanco.Origem = cdg.Origem;

                context.SaveChanges();
            }


        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var crm = context.CodigoIntegracao.Find(id);
                context.CodigoIntegracao.Remove(crm);
                context.SaveChanges();

            }
        }
    }
}