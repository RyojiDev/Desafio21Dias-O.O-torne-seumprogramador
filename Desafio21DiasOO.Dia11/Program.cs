using Desafio21DiasOO.Dia11.Models;
using System;

namespace Desafio21DiasOO.Dia11
{
    class Program
    {
        static void Main(string[] args)
        {
            var fisicas = new Fisica().Busca();
            var juridicas = new Juridica().Busca();

            foreach(var item in fisicas)
            {
                Console.WriteLine(item);
            }

            foreach(var item in juridicas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
