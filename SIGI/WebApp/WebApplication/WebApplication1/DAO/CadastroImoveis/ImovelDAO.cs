using SIGI.Models.CadastroImovel;
using SIGI.Models.CadastroImovel.Caracteristicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.CadastroImovel;
using WebApplication1.Models.CadastroImovel.ListaDocumentos;

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

       

        public void Alterar(Imovel imovel)
        {


            using (var context = new SIGIContext())
            {
                Imovel imovelDoBanco = context.Imovel.FirstOrDefault(c => c.ID == imovel.ID);

                imovelDoBanco.Anexos = (imovel.Anexos != null? imovel.Anexos: imovelDoBanco.Anexos);

                imovelDoBanco.CaracteristicasGerais = (imovel.CaracteristicasGerais != null? imovel.CaracteristicasGerais : imovelDoBanco.CaracteristicasGerais);

                imovelDoBanco.CaracteristicasPrincipais= (imovel.CaracteristicasPrincipais != null? imovel.CaracteristicasPrincipais: imovelDoBanco.CaracteristicasPrincipais);

                imovelDoBanco.CdgIntegracao = (imovel.CdgIntegracao != null? imovel.CdgIntegracao: imovelDoBanco.CdgIntegracao);

                imovelDoBanco.Crm = (imovel.Crm != null? imovel.Crm: imovelDoBanco.Crm);

                imovelDoBanco.DescricaoBreve = (imovel.DescricaoBreve != null? imovel.DescricaoBreve: imovelDoBanco.DescricaoBreve);

                imovelDoBanco.DescricaoCompleta = (imovel.DescricaoCompleta != null? imovel.DescricaoCompleta: imovelDoBanco.DescricaoCompleta);

                imovelDoBanco.Detalhes = (imovel.Detalhes != null? imovel.Detalhes: imovelDoBanco.Detalhes);

                imovelDoBanco.Documentos = (imovel.Documentos != null? imovel.Documentos: imovelDoBanco.Documentos);

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

        public void AdicionaCaracteristicaPrincipal(CaracteristicaPrincipal caracteristica,
            Imovel imovel)
        {
            imovel.CaracteristicasPrincipais.Add(caracteristica);
        }
        public void RemoveCaracteristicaPrincipal(CaracteristicaPrincipal caracteristica,
         Imovel imovel)
        {
            imovel.CaracteristicasPrincipais.Remove(caracteristica);
        }

        public void AdicionaCaracteristicaGeral(CaracteristicasGerais caracteristica,
            Imovel imovel)
        {
            imovel.CaracteristicasGerais.Add(caracteristica);
        }


        public void RemoveCaracteristicaGeral(CaracteristicasGerais caracteristica,
            Imovel imovel)
        {
            imovel.CaracteristicasGerais.Remove(caracteristica);
        }

        public void AdicionaAnexo(Anexo anexo,
           Imovel imovel)
        {
            imovel.Anexos.Add(anexo);
        }


        public void RemoveAnexo(Anexo anexo,
            Imovel imovel)
        {
            imovel.Anexos.Remove(anexo);
        }

        public void AdicionaCrm(Crm crm,
        Imovel imovel)
        {
            imovel.Crm.Add(crm);
        }


        public void RemoveCrm(Crm crm,
            Imovel imovel)
        {
            imovel.Crm.Remove(crm);
        }

        public void AdicionaDocumentos(Documentos documentos,
        Imovel imovel)
        {
            imovel.Documentos.Add(documentos);
        }


        public void RemoveDocumentos(Documentos documentos,
            Imovel imovel)
        {
            imovel.Documentos.Remove(documentos);
        }
    }
}