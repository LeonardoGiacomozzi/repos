using SIGI.Models.CadastroImovel.Valores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO.CadastroImoveis
{
    public class ValorLocacaoDAO
    {
      
            public void Adiciona(ValorLocacao valor)
            {
                using (var context = new SIGIContext())
                {
                    context.ValorLocacao.Add(valor);
                    context.SaveChanges();
                }
            }

            public IList<ValorLocacao> Listar()
            {


                using (var context = new SIGIContext())
                {

                    return context.ValorLocacao.ToList();
                }


            }
            public ValorLocacao BuscarPorId(int Id)
            {
                using (var context = new SIGIContext())
                {
                    return context.ValorLocacao.Find(Id);

                }
            }

           
        

            public void Alterar(ValorLocacao valor)
            {


                using (var context = new SIGIContext())
                {
                ValorLocacao ValorLocacao = context.ValorLocacao.FirstOrDefault(d => d.ID == valor.ID);
                ValorLocacao.IPTU = valor.IPTU;
                ValorLocacao.Condominio = valor.Condominio;
                ValorLocacao.Mensalidade= valor.Mensalidade;
                ValorLocacao.DescricaoPagamento= valor.DescricaoPagamento;

                    context.SaveChanges();
                }


            }

            
            public void Deletar(int id)
            {
                using (var context = new SIGIContext())
                {
                    var ValorLocacao = context.ValorLocacao.Find(id);
                    context.ValorLocacao.Remove(ValorLocacao);
                    context.SaveChanges();

                }
            }
    }
}