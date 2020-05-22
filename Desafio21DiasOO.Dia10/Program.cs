using Desafio21DiasOO.Dia10.Models;
using System;

namespace Desafio21DiasOO.Dia10
{
    class Program
    {
        static void Main(string[] args)
        {
            var fisicas = Fisica.Busca();
            var juridicas = Juridica.Busca();


            new Fisica() { Nome = "Ryoji", Endereco = "Tornese um programador", Id = 1 }.Salvar();
            new Juridica() { Nome = "Teste", Endereco = "Tornese um programador", Id = 1 }.Salvar();
        }
    }
}
