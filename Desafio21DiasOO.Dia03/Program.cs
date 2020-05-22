using Desafio21DiasOO.Dia03.Models;
using Desafio21DiasOO.Dia04.Models;
using System;

namespace Desafio21DiasOO.Dia03
{
    class Program
    {
        static void Main(string[] args)
        {
            Receita boloChocolate = new Receita();
            boloChocolate.Name = "Bolo de chocolate";
            boloChocolate.Tamanho = "Grande";
            boloChocolate.Peso = 1.5;
            boloChocolate.preco = 35.00;

            Receita boloCereja = new Receita();
            boloCereja.Name = "Bolo Cereja";
            boloCereja.Peso = 1.7;
            boloCereja.Tamanho = "Medio";
            boloCereja.preco = 40.00;

            Receita boloMorango = new Receita();
            boloMorango.Name = "Bolo Cereja";
            boloMorango.Peso = 1.7;
            boloMorango.Tamanho = "Pequeno";
            boloMorango.preco = 40.00;

            Livro livro = new Livro()
            {
                Id = 1,
                Nome = "Harry Potter",
                //Versao = "2.0"
            };
            



        }
    }
}
