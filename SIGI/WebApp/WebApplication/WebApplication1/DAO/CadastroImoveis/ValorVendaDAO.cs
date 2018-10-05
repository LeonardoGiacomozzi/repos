using SIGI.Models.CadastroImovel;
using SIGI.Models.CadastroImovel.Valores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO.CadastroImoveis
{
    public class ValorVendaDAO
    {
        public void Adiciona(Valor valor)
        {
            using (var context = new SIGIContext())
            {
                context.ValorVenda.Add(valor);
                context.SaveChanges();
            }
        }

        public IList<Valor> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.ValorVenda.ToList();
            }


        }
        public Valor BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.ValorVenda.Find(Id);

            }
        }




        public void Alterar(Valor valor)
        {


            using (var context = new SIGIContext())
            {
                Valor ValorVenda = context.ValorVenda.FirstOrDefault(d => d.ID == valor.ID);
                if (valor.Tipo==ETipoNegocio.Locação)
                {
                    ValorVenda.EstaAverbado = false;
                    ValorVenda.EstaEsscriturado = false;
                    ValorVenda.PodeFinanciar = false;
                    ValorVenda.DescricaoPagamento = valor.DescricaoPagamento;
                    ValorVenda.ValorDeVenda = 0;
                    ValorVenda.Condominio = valor.Condominio;
                    ValorVenda.IPTU = valor.IPTU;
                    ValorVenda.Mensalidade = valor.Mensalidade;

                }
                else { 
                    ValorVenda.EstaAverbado = valor.EstaAverbado;
                    ValorVenda.EstaEsscriturado = valor.EstaEsscriturado;
                    ValorVenda.PodeFinanciar = valor.PodeFinanciar;
                    ValorVenda.DescricaoPagamento = valor.DescricaoPagamento;
                    ValorVenda.ValorDeVenda = valor.ValorDeVenda;
                    ValorVenda.Condominio =0;
                    ValorVenda.IPTU = 0;
                    ValorVenda.Mensalidade = 0;
                }
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