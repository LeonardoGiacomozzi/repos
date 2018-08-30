﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIGI.DAO;
using SIGI.Models.CadastroEndereco;

namespace SIGI.Testes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InserirBrasilSantaCatarinaBlumenauBairoVelhaCentral()
        {
            Pais pais = new Pais();
            pais.Nome = "Brasil";
            PaisDAO paisDAO = new PaisDAO();
            paisDAO.Adiciona(pais);

            Estado estado = new Estado();
            estado.Pais = pais;
            estado.Nome = "Santa Catarina";
            EstadoDAO estadoDAO = new EstadoDAO();
            estadoDAO.Adiciona(estado);

            var teste = estadoDAO.Listar().Where(e=> e.Pais.Nome == "Brasil" && e.Nome == "Santa Catarina");
            Assert.IsTrue(teste.Any(),"AChou");
                
        }
    }
}
