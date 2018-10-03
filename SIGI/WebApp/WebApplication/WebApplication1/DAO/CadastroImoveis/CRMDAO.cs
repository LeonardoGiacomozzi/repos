using SIGI.DAO;
using SIGI.Models.CadastroImovel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DAO.CadastroImoveis
{
    public class CRMDAO
    {
       
            public void Adiciona(Crm crm)
            {
                using (var context = new SIGIContext())
                {
                    context.CRM.Add(crm);
                    context.SaveChanges();
                }
            }

            public IList<Crm> Listar()
            {


                using (var context = new SIGIContext())
                {

                    return context.CRM.ToList();
                }


            }



            public Crm BuscarPorId(int Id)
            {
                using (var context = new SIGIContext())
                {
                    return context.CRM.Find(Id);

                }
            }

            public Crm BuscaUltimo()
            {
                using (var context = new SIGIContext())
                {
                    return context.CRM.Last();

                }
            }

            public void Alterar(Crm crm)
            {
              

                using (var context = new SIGIContext())
                {
                    Crm crmDoBanco = context.CRM.FirstOrDefault(c => c.ID == crm.ID);
                    crmDoBanco.Descricao = crm.Descricao;

                    context.SaveChanges();
                }

            }

            public void Deletar(int id)
            {
                using (var context = new SIGIContext())
                {
                    var crm = context.CRM.Find(id);
                    context.CRM.Remove(crm);
                    context.SaveChanges();

                }
            }
        
    }
}