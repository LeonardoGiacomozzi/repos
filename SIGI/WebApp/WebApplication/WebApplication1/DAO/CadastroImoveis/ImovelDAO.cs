using SIGI.Models.CadastroImovel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO.CadastroImoveis
{
    public class ImovelDAO
    {
        public void Adiciona(Imovel imovel)
        {
            using (var context = new SIGIContext())
            {
                context.Imovel.Add(imovel);
                context.SaveChanges();
            }
        }

        public IList<Imovel> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.Imovel.ToList();
            }


        }



        public Imovel BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.Imovel.Find(Id);

            }
        }

        public IList<Imovel> ListarFullPropriety()
        {


            using (var context = new SIGIContext())
            {

                var lista =context.Imovel.ToList();
                IList<Imovel> nova = new List<Imovel>();
                foreach (var imovel in lista)
                {
                    nova.Add(GetFullPropriety(imovel));
                }
                return nova;
            }


        }
        public Imovel GetFullPropriety(Imovel imovel) {

            Imovel imovelnovo = BuscarPorId(imovel.ID);
            imovelnovo.Valor = new ValorVendaDAO().BuscarPorId(imovelnovo.ValorID);
          
            
            imovelnovo.Endereco = new EnderecoDAO().BuscarPorId(imovelnovo.EnderecoID);
            imovelnovo.Endereco = new EnderecoDAO().GetFullProperties(imovelnovo.Endereco);
         
            //imovelnovo.Documentos
            //imovelnovo.Responsavel
            //imovelnovo.CaracteristicasGerais
            //imovelnovo.CaracteristicasPrincipais
            //imovelnovo.Anexos
            return imovelnovo;
        }

        public void Alterar(Imovel imovel)
        {


            using (var context = new SIGIContext())
            {
                Imovel imovelDoBanco = context.Imovel.FirstOrDefault(c => c.ID == imovel.ID);

         
                imovelDoBanco.CaracteristicasGerais = (imovel.CaracteristicasGerais != null? imovel.CaracteristicasGerais : imovelDoBanco.CaracteristicasGerais);

                imovelDoBanco.CaracteristicasPrincipais= (imovel.CaracteristicasPrincipais != null? imovel.CaracteristicasPrincipais: imovelDoBanco.CaracteristicasPrincipais);

                //imovelDoBanco.CdgIntegracao = (imovel.CdgIntegracao != null? imovel.CdgIntegracao: imovelDoBanco.CdgIntegracao);
              

                imovelDoBanco.TipoNegocio = imovel.TipoNegocio;

                imovelDoBanco.TipoDeImovel = imovel.TipoDeImovel;

                imovelDoBanco.ResponsavelID = imovel.ResponsavelID;

                imovelDoBanco.EnderecoID = imovel.EnderecoID;

                imovelDoBanco.Finalidade = imovel.Finalidade;

                imovelDoBanco.DescricaoBreve = (imovel.DescricaoBreve != null? imovel.DescricaoBreve: imovelDoBanco.DescricaoBreve);

                imovelDoBanco.DescricaoCompleta = (imovel.DescricaoCompleta != null? imovel.DescricaoCompleta: imovelDoBanco.DescricaoCompleta);

                imovelDoBanco.Detalhes = (imovel.Detalhes != null? imovel.Detalhes: imovelDoBanco.Detalhes);

                new ValorVendaDAO().Alterar(imovel.Valor);

                imovelDoBanco.Endereco = (imovel.Endereco != null? imovel.Endereco: imovelDoBanco.Endereco);

                imovelDoBanco.MetragemTotal = (imovel.MetragemTotal != 0.0? imovel.MetragemTotal: imovelDoBanco.MetragemTotal);

                imovelDoBanco.MetragemUtil = (imovel.MetragemUtil != 0.0? imovel.MetragemUtil: imovelDoBanco.MetragemUtil);

                imovelDoBanco.Responsavel = (imovel.Responsavel != null? imovel.Responsavel: imovelDoBanco.Responsavel);


                context.SaveChanges();
            }


        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var imovel = context.Imovel.Find(id);
                context.Imovel.Remove(imovel);
                context.SaveChanges();

            }
        }

        public IList<ETipoNegocio> ListaTipoNegocio() {
            var lista = new List<ETipoNegocio>();
            lista.Add(ETipoNegocio.Locação);
            lista.Add(ETipoNegocio.Venda);
            return lista;
        }

        public IList<EtipoDeImovel> ListaTipoImovel()
        {
            var lista = new List<EtipoDeImovel>();
            lista.Add(EtipoDeImovel.Apartamento);
            lista.Add(EtipoDeImovel.Casa);
            lista.Add(EtipoDeImovel.Chacara);
            lista.Add(EtipoDeImovel.Galpão);
            lista.Add(EtipoDeImovel.Sitio);
            lista.Add(EtipoDeImovel.Terreno);
            return lista;
        }

        public IList<EFinalidadeImovel> ListaFinalidadeNegocio()
        {
            var lista = new List<EFinalidadeImovel>();
            lista.Add(EFinalidadeImovel.Comercial);
            lista.Add(EFinalidadeImovel.Residencial);
            lista.Add(EFinalidadeImovel.Rural);

            return lista;
        }

       
     
    }
}