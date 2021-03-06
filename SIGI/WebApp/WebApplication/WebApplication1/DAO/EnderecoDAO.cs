﻿using SIGI.Models.CadastroEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO
{
    public class EnderecoDAO
    {
        public void Adiciona(Endereco endereco)
        {
            using (var context = new SIGIContext())
            {
                context.Enderecos.Add(endereco);
                context.SaveChanges();
            }
        }

        public IList<Endereco> Listar()
        {


            using (var context = new SIGIContext())
            {

                return context.Enderecos.ToList();
            }


        }
        public IList<Endereco> ListarFullProperties()
        {
            var listaEnderecos = this.Listar();
            IList<Endereco> result = new List<Endereco>();
            foreach (var endereco in listaEnderecos)
                result.Add(GetFullProperties(endereco));
            return result;
        }
        public Endereco GetFullProperties(Endereco endereco)
        {
            
            endereco.Cidade = new CidadeDAO().BuscarPorId(endereco.CidadeID);
            endereco.Cidade = new CidadeDAO().GetFullProperties(endereco.Cidade);
            return endereco;
        }
        public IList<Estado> BuscaEstadosDoPais(int PaisID)
        {

            EstadoDAO estadoDAO = new EstadoDAO();

            return estadoDAO.BuscaPorPais(PaisID);

        }


        public IList<Cidade> BuscaCidadeDoEstado(int EstadoID)
        {

            CidadeDAO cidadeDAO = new CidadeDAO();

            return cidadeDAO.BuscaPorEstado(EstadoID);

        }

        public Endereco BuscarPorId(int Id)
        {
            using (var context = new SIGIContext())
            {
                return context.Enderecos.Find(Id);

            }
        }

        public Endereco BuscaUltimo()
        {
            using (var context = new SIGIContext())
            {
                return context.Enderecos.Last();

            }
        }

        public void Alterar(Endereco endereco)
        {

            using (var context = new SIGIContext())
            {
                Endereco enderecoDoBanco = context.Enderecos.FirstOrDefault(e => e.ID == endereco.ID);
                enderecoDoBanco.Rua = (endereco.Rua != null ? endereco.Rua : enderecoDoBanco.Rua);
                enderecoDoBanco.CEP = (endereco.CEP != null ? endereco.CEP : enderecoDoBanco.CEP);
                enderecoDoBanco.Bairro = (endereco.Bairro != null ? endereco.Bairro : enderecoDoBanco.Bairro);
                enderecoDoBanco.CidadeID = (endereco.CidadeID != 0 ? endereco.CidadeID : enderecoDoBanco.CidadeID);
               enderecoDoBanco.Numero = (endereco.Numero != 0 ? endereco.Numero : enderecoDoBanco.Numero);
                enderecoDoBanco.Complemento = (endereco.Complemento != null ? endereco.Complemento : enderecoDoBanco.Complemento);
                context.SaveChanges();
            }


        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var endereco = context.Enderecos.Find(id);
                context.Enderecos.Remove(endereco);
                context.SaveChanges();

            }

        }
    }
}