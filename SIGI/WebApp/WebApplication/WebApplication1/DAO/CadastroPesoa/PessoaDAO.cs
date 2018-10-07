using SIGI.Models.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO.CadastroPesoa
{
    public class PessoaDAO
    {
        public void Adiciona(Pessoa pessoa)
        {
            using (var context = new SIGIContext())
            {
                if (pessoa.Cpf==null)
                {
                    pessoa.TipoPessoa = EPessoa.Pessoa_Juridica;
                    pessoa.Cpf = "";
                   
                    pessoa.EEstadoCivil = EEstadoCivil.nullo;
                    pessoa.Nacionalidade = "";
                    pessoa.Profissao = "";
                    pessoa.Rg = "";
                    if (pessoa.ETipo==ETipoPessoa.Funcionario)
                    {
                        pessoa.ETipo = ETipoPessoa.Colaborador;
                    }

                }
                else
                {
                    pessoa.TipoPessoa = EPessoa.Pessoa_Fisica;
                    pessoa.WebSite = "";
                    pessoa.Cnpj = "";
                }

                context.Pessoa.Add(pessoa);
                context.SaveChanges();
            }
        }

        public IList<Pessoa> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.Pessoa.ToList();
            }


        }
        public IList<Pessoa> ListarFullProperties()
        {
            var listaEnderecos= this.Listar();
            IList<Pessoa> result = new List<Pessoa>();
            foreach (var pessoa in listaEnderecos)
                result.Add(GetFullProperties(pessoa));
            return result;
        }
        public Pessoa GetFullProperties(Pessoa pessoa)
        {
            pessoa.Endereco = new EnderecoDAO().BuscarPorId(pessoa.EnderecoID);
          
            return pessoa;
        }




        public Pessoa BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.Pessoa.Find(Id);

            }
        }

       public void Alterar(Pessoa pessoa)
        {


            using (var context = new SIGIContext())
            {
                Pessoa pessoaDoBanco = context.Pessoa.FirstOrDefault(p => p.ID == pessoa.ID);
                pessoaDoBanco.Nome = (pessoa.Nome != null ? pessoa.Nome : pessoaDoBanco.Nome);

                pessoaDoBanco.InscricaoEstadual = (pessoa.InscricaoEstadual != null ? pessoa.InscricaoEstadual: pessoaDoBanco.InscricaoEstadual);

                pessoaDoBanco.InscricaoMunicipal = (pessoa.InscricaoMunicipal != null ? pessoa.InscricaoMunicipal: pessoaDoBanco.InscricaoMunicipal);


                pessoaDoBanco.Observacao= (pessoa.Observacao!= null ? pessoa.Observacao: pessoaDoBanco.Observacao);

                pessoaDoBanco.ETipo = pessoa.ETipo;

                pessoaDoBanco.Endereco= (pessoa.Endereco!= null ? pessoa.Endereco: pessoaDoBanco.Endereco);

                pessoaDoBanco.Telefone= (pessoa.Telefone!= null ? pessoa.Telefone: pessoaDoBanco.Telefone);

                pessoaDoBanco.Telefone= (pessoa.Telefone!= null ? pessoa.Telefone: pessoaDoBanco.Telefone);

                pessoaDoBanco.EmailPrincipal= (pessoa.EmailPrincipal!= null ? pessoa.EmailPrincipal: pessoaDoBanco.EmailPrincipal);

                pessoaDoBanco.Celular= (pessoa.Celular!= null ? pessoa.Celular: pessoaDoBanco.Celular);
                if (pessoa.TipoPessoa==EPessoa.Pessoa_Fisica)
                {
                    pessoaDoBanco.Cpf= (pessoa.Cpf!= null ? pessoa.Cpf: pessoaDoBanco.Cpf);
                    pessoaDoBanco.EEstadoCivil = pessoa.EEstadoCivil;
                    pessoaDoBanco.Rg= (pessoa.Rg!= null ? pessoa.Rg: pessoaDoBanco.Rg);
                    pessoaDoBanco.Profissao= (pessoa.Profissao!= null ? pessoa.Profissao: pessoaDoBanco.Profissao);
                    pessoaDoBanco.Nacionalidade= (pessoa.Nacionalidade!= null ? pessoa.Nacionalidade : pessoaDoBanco.Nacionalidade);

                    pessoaDoBanco.Cnpj=null;
                    pessoa.WebSite = null;

                }
                else
                {
                    pessoaDoBanco.Cnpj= (pessoa.Cnpj!= null ? pessoa.Cnpj: pessoaDoBanco.Cnpj);
                    pessoa.WebSite = (pessoa.WebSite != null ? pessoa.WebSite : pessoaDoBanco.WebSite);

                    pessoaDoBanco.Cpf=null;
                   
                    pessoaDoBanco.EEstadoCivil = EEstadoCivil.nullo;
                    pessoaDoBanco.Rg = null;
                    pessoaDoBanco.Profissao = null;
                    pessoaDoBanco.Nacionalidade = null;

                }

                context.SaveChanges();
            }


        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var pessoa = context.Pessoa.Find(id);
                context.Pessoa.Remove(pessoa);
                context.SaveChanges();

            }
        }

        public IList<EEstadoCivil> ListaEstadoCIvil()
        {
            var lista = new List<EEstadoCivil>();
            lista.Add(EEstadoCivil.Casado);
            lista.Add(EEstadoCivil.Solteiro);
            lista.Add(EEstadoCivil.Divorciado);
            lista.Add(EEstadoCivil.Viuvo);

            return lista;
        }


        public IList<ETipoPessoa> ListaTipoPessoa()
        {
            var lista = new List<ETipoPessoa>();
            lista.Add(ETipoPessoa.Cliente);
            lista.Add(ETipoPessoa.Fornecedor);
            lista.Add(ETipoPessoa.Colaborador);
            lista.Add(ETipoPessoa.Funcionario);

            return lista;
        }
        public IList<EPessoa> ListaPessoa()
        {
            var lista = new List<EPessoa>();
            lista.Add(EPessoa.Pessoa_Fisica);
            lista.Add(EPessoa.Pessoa_Juridica);
         
            return lista;
        }

        public IList<Pessoa> ListaPorFuncao(ETipoPessoa tipo)
        {
            var lista = ListarFullProperties();
            var nova = new List<Pessoa>();
            foreach (var item in lista)
            {
                if (item.ETipo==tipo)
                {
                    nova.Add(item);
                }
            }
            return nova;
        }
    }
}