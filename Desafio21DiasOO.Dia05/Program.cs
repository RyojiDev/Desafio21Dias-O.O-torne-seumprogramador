using Desafio21DiasOO.Dia05.Models;
using System;

namespace Desafio21DiasOO.Dia05
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Ryoji", "Rua travessa da palma, 106");
            Pessoa pessoa1 = new Pessoa()
            {
                Nome = "Teste",
                Endereco = "Novo Endereço",
                
            };

            Fisica pessoaFisica = new Fisica();
            Juridica pessoaJuridica = new Juridica("nome","teste","teste","ddhdhd");

            Console.WriteLine("Hello World!");
        }
    }
}
