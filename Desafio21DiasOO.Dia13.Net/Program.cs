using DataBasePessoa;
using Desafio21DiasOO.Dia13.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio21DiasOO.Dia13.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Fisica fisica = new Fisica();

            
            foreach(Fisica lista in fisica.ToList()) { 
            
            Console.WriteLine("Nome: " + lista.Nome);
                Console.WriteLine();
                Console.WriteLine("Cpf:" + lista.Cpf);
                Console.WriteLine();
                Console.WriteLine("Endereco: " + lista.Endereco);


            }
        }
    }
}
