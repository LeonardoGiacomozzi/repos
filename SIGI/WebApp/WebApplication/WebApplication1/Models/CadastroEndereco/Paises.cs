﻿namespace SIGI.Models.CadastroEndereco
{
    public class Pais
    {
        public int Id { get;  set; }

        public string Nome { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}