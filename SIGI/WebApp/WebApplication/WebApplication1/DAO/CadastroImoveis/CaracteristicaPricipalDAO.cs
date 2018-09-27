using SIGI.Models.CadastroImovel.Caracteristicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO.CadastroImoveis
{
    public class CaracteristicasPricipaisDAO
    {

        public void Adiciona(CaracteristicaPrincipal caracteristica)
        {
            using (var context = new SIGIContext())
            {
                context.CaracteristicaPrincipal.Add(caracteristica);
                context.SaveChanges();
            }
        }

        public IList<CaracteristicaPrincipal> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.CaracteristicaPrincipal.ToList();
            }


        }

        public IList<CaracteristicaPrincipal> ListarAtivos()
        {


            using (var context = new SIGIContext())
            {
                var caracteristicas = context.CaracteristicaPrincipal.ToList();
                IList<CaracteristicaPrincipal> ativos = new List<CaracteristicaPrincipal>();
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

        public IList<CaracteristicaPrincipal> ListarInativos()
        {


            using (var context = new SIGIContext())
            {
                var caracteristicas = context.CaracteristicaPrincipal.ToList();
                IList<CaracteristicaPrincipal> Inativos = new List<CaracteristicaPrincipal>();
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
        public IList<ETipoDeDado> listaTipo()
        {
            var tipos = new List<ETipoDeDado>();
            tipos.Add(ETipoDeDado.Quantidade);
            tipos.Add(ETipoDeDado.Data);
            tipos.Add(ETipoDeDado.Logico);
            return tipos;

        }


        public CaracteristicaPrincipal BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.CaracteristicaPrincipal.Find(Id);

            }
        }

        public CaracteristicaPrincipal BuscaUltimo()
        {
            using (var context = new SIGIContext())
            {
                return context.CaracteristicaPrincipal.Last();

            }
        }
        public void Desativa(int id)
        {
            using (var context = new SIGIContext())
            {
                var caracteristica = context.CaracteristicaPrincipal.FirstOrDefault(d => d.ID == id);
                caracteristica.Ativo = false;
                context.SaveChanges();

            }
        }

            public void Alterar(CaracteristicaPrincipal caracteristica)
        {


            using (var context = new SIGIContext())
            {
                CaracteristicaPrincipal caracteristicaBanco = context.CaracteristicaPrincipal.FirstOrDefault(d => d.ID == caracteristica.ID);
                caracteristicaBanco.Nome= caracteristica.Nome;
                caracteristicaBanco.TipoDeDado= caracteristica.TipoDeDado;
                caracteristicaBanco.Valor= caracteristica.Valor;
                caracteristicaBanco.Ativo = caracteristica.Ativo;

                context.SaveChanges();
            }


        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var caracteristica = context.CaracteristicaPrincipal.Find(id);
                context.CaracteristicaPrincipal.Remove(caracteristica);
                context.SaveChanges();

            }
        }
    }
}