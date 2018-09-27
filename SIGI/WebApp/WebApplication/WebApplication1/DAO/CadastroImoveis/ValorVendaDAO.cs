using SIGI.Models.CadastroImovel.Valores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO.CadastroImoveis
{
    public class ValorVendaDAO
    {
        public void Adiciona(ValorVenda valor)
        {
            using (var context = new SIGIContext())
            {
                context.ValorVenda.Add(valor);
                context.SaveChanges();
            }
        }

        public IList<ValorVenda> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.ValorVenda.ToList();
            }


        }
        public ValorVenda BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.ValorVenda.Find(Id);

            }
        }




        public void Alterar(ValorVenda valor)
        {


            using (var context = new SIGIContext())
            {
                ValorVenda ValorVenda = context.ValorVenda.FirstOrDefault(d => d.ID == valor.ID);
                ValorVenda.EstaAverbado = valor.EstaAverbado;
                ValorVenda.EstaEsscriturado = valor.EstaEsscriturado;
                ValorVenda.PodeFinanciar = valor.PodeFinanciar;
                ValorVenda.DescricaoPagamento = valor.DescricaoPagamento;
                ValorVenda.ValorDeVenda = valor.ValorDeVenda;

                context.SaveChanges();
            }


        }


        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var ValorVenda = context.ValorVenda.Find(id);
                context.ValorVenda.Remove(ValorVenda);
                context.SaveChanges();

            }
        }
    }
}