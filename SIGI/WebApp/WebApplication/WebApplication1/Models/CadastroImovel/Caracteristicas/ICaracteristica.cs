using System;

namespace SIGI.Models.CadastroImovel.Caracteristicas
{
    public interface ICaracteristica
    {
        ETipoDeDado TipoDeDado { get; set; }

        string Nome { get; set; }

        string Valor { get;  set; }

        int ConverteQuantidade();

        bool ConverteLogico();

        DateTime ConverteData();

        void Converte(ETipoDeDado tipo);

    }

   
}