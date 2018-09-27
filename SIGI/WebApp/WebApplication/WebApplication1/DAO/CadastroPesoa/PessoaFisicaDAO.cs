using SIGI.Models.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO.CadastroPesoa
{
    public class PessoaFisicaDAO
    {
        public void Adiciona(PessoaFisica pessoaFisica)
        {
            using (var context = new SIGIContext())
            {
                context.PessoaFisica.Add(pessoaFisica);
                context.SaveChanges();
            }
        }

        public IList<PessoaFisica> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.PessoaFisica.ToList();
            }


        }



        public PessoaFisica BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.PessoaFisica.Find(Id);

            }
        }

       public void Alterar(PessoaFisica pessoaFisica)
        {


            using (var context = new SIGIContext())
            {
                PessoaFisica pessoaDoBanco = context.PessoaFisica.FirstOrDefault(p => p.ID == pessoaFisica.ID);
                pessoaDoBanco.Nome = (pessoaFisica.Nome != null ? pessoaFisica.Nome : pessoaDoBanco.Nome);

                pessoaDoBanco.InscricaoEstadual = (pessoaFisica.InscricaoEstadual != null ? pessoaFisica.InscricaoEstadual: pessoaDoBanco.InscricaoEstadual);

                pessoaDoBanco.InscricaoMunicipal = (pessoaFisica.InscricaoMunicipal != null ? pessoaFisica.InscricaoMunicipal: pessoaDoBanco.InscricaoMunicipal);

                pessoaDoBanco.Nacionalidade= (pessoaFisica.Nacionalidade!= null ? pessoaFisica.Nacionalidade : pessoaDoBanco.Nacionalidade);

                pessoaDoBanco.Observacao= (pessoaFisica.Observacao!= null ? pessoaFisica.Observacao: pessoaDoBanco.Observacao);

                pessoaDoBanco.Profissao= (pessoaFisica.Profissao!= null ? pessoaFisica.Profissao: pessoaDoBanco.Profissao);

                pessoaDoBanco.Rg= (pessoaFisica.Rg!= null ? pessoaFisica.Rg: pessoaDoBanco.Rg);

                pessoaDoBanco.Telefone= (pessoaFisica.Telefone!= null ? pessoaFisica.Telefone: pessoaDoBanco.Telefone);

                pessoaDoBanco.Telefone= (pessoaFisica.Telefone!= null ? pessoaFisica.Telefone: pessoaDoBanco.Telefone);

                pessoaDoBanco.Celular= (pessoaFisica.Celular!= null ? pessoaFisica.Celular: pessoaDoBanco.Celular);

                pessoaDoBanco.Cpf= (pessoaFisica.Cpf!= null ? pessoaFisica.Cpf: pessoaDoBanco.Cpf);

                pessoaDoBanco.DataNascimento= (pessoaFisica.DataNascimento!= null ? pessoaFisica.DataNascimento: pessoaDoBanco.DataNascimento);

                pessoaDoBanco.EmailPrincipal= (pessoaFisica.EmailPrincipal!= null ? pessoaFisica.EmailPrincipal: pessoaDoBanco.EmailPrincipal);

                pessoaDoBanco.Endereco= (pessoaFisica.Endereco!= null ? pessoaFisica.Endereco: pessoaDoBanco.Endereco);

                pessoaDoBanco.EEstadoCivil = pessoaFisica.EEstadoCivil;

                pessoaDoBanco.ETipo = pessoaFisica.ETipo;



                

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