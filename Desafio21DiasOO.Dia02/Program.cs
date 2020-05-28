using Desafio21DiasOO.Dia02.Models.Alunos;
using ORMDesafio21Dias;
using System;
using System.Collections.Generic;

namespace Desafio21DiasOO.Dia02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pessoa danilo = new Pessoa();
            danilo.Id = 1;
            danilo.Nome = "Danilo Aparecido";
            danilo.Endereco = "Rua 1234";

            Pessoa wagner = new Pessoa();
            wagner.Id = 2;
            wagner.Nome = "wagner Braga";
            wagner.Endereco = "rua 1234";

            Pessoa marcos = new Pessoa();
            marcos.Id = 3;
            marcos.Nome = "Marcos palladino";
            marcos.Endereco = "Rua 1234";

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(danilo);
            pessoas.Add(wagner);
            pessoas.Add(marcos);

            

            Console.WriteLine("Hello World!");*/

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Ryoji";
            pessoa.Endereco = "Rua de teste ORM";
            new Service(pessoa).Save();
           
        }
    }
}
