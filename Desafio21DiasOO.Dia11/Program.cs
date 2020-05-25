using Desafio21DiasOO.Dia11.Models;
using System;

namespace Desafio21DiasOO.Dia11
{
    class Program
    {
        static void Main(string[] args)
        {
            Fisica fisica = new Fisica("Mateus", "123 teste", 1);

            

            
            Console.WriteLine(fisica.Nome);

            new Fisica() { Nome = "Mateus", Endereco = "123 teste", Id = 1 }.Salvar();
            new Juridica() { Nome = "Empresa Mateus", Endereco = "123 teste", Id = 2 }.Salvar();



            /* var fisicas = new Fisica().Busca();
             var juridicas = new Juridica().Busca();

             foreach(var item in fisicas)
             {
                 Console.WriteLine(item.Nome);

             }

             foreach(var item in juridicas)
             {
                 Console.WriteLine(item);
             }*/
        }
    }
}
