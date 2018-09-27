using SIGI.Models.CadastroImovel.Caracteristicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO.CadastroImoveis
{
    public class CaracteristicaGeralDAO
    {
        public void Adiciona(CaracteristicasGerais caracteristica)
        {
            using (var context = new SIGIContext())
            {
                context.CaracteristicasGerais.Add(caracteristica);
                context.SaveChanges();
            }
        }

        public IList<CaracteristicasGerais> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.CaracteristicasGerais.ToList();
            }


        }

        public IList<CaracteristicasGerais> ListarAtivos()
        {


            using (var context = new SIGIContext())
            {
                var caracteristicas = context.CaracteristicasGerais.ToList();
                IList<CaracteristicasGerais> ativos = new List<CaracteristicasGerais>();
                foreach (var caracteristica in caracteristicas)
                {
                    if (caracteristica.Ativo)
                    {
                        ativos.Add(caracteristica);
                    }
                }

                return ativos;
            }


        }

        public IList<CaracteristicasGerais> ListarInativos()
        {


            using (var context = new SIGIContext())
            {
                var caracteristicas = context.CaracteristicasGerais.ToList();
                IList<CaracteristicasGerais> Inativos = new List<CaracteristicasGerais>();
                foreach (var caracteristica in caracteristicas)
                {
                    if (!caracteristica.Ativo)
                    {
                        Inativos.Add(caracteristica);
                    }
                }

                return Inativos;
            }


        }


        public CaracteristicasGerais BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.CaracteristicasGerais.Find(Id);

            }
        }

        public CaracteristicasGerais BuscaUltimo()
        {
            using (var context = new SIGIContext())
            {
                return context.CaracteristicasGerais.Last();

            }
        }
        public void Desativa(int id)
        {
            using (var context = new SIGIContext())
            {
                var caracteristica = context.CaracteristicasGerais.FirstOrDefault(d => d.ID == id);
                caracteristica.Ativo = false;
                context.SaveChanges();

            }
        }

        public void Alterar(CaracteristicasGerais caracteristica)
        {


            using (var context = new SIGIContext())
            {
                CaracteristicasGerais caracteristicaBanco = context.CaracteristicasGerais.FirstOrDefault(d => d.ID == caracteristica.ID);
                caracteristicaBanco.Nome = caracteristica.Nome;
                caracteristicaBanco.TipoDeDado = caracteristica.TipoDeDado;
                caracteristicaBanco.Valor = caracteristica.Valor;
                caracteristicaBanco.Ativo = caracteristica.Ativo;

                context.SaveChanges();
            }


        }

        public IList<ETipoDeDado> listaTipo()
        {
            var tipos = new List<ETipoDeDado>();
            tipos.Add(ETipoDeDado.Quantidade);
            tipos.Add(ETipoDeDado.Data);
            tipos.Add(ETipoDeDado.Logico);
            return tipos;

        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var caracteristica = context.CaracteristicasGerais.Find(id);
                context.CaracteristicasGerais.Remove(caracteristica);
                context.SaveChanges();

            }
        }
    }
}