using Desafio21DiasOO.Dia07.Models;
using System;

namespace Desafio21DiasOO.Dia07
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            bool yesNo = false;

            Console.WriteLine("Seja bem vindo a Tela de cadastro de Pessoa/ Fisicas!");
            Console.WriteLine("====================================================");
            Console.WriteLine("");
            Console.Write("Você gostaria de cadastrar agora (sim = 1, não = 2)? ");
            int resp = int.Parse(Console.ReadLine());
            if(resp == 1)
            {
                yesNo = true;
            }

            if (yesNo)
            { 
                while (yesNo)
                {
                    Console.Write("Digite os dados para cadastro: ");
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("");
                    Console.Write("Cpf: ");
                    string cpf = Console.ReadLine();
                    new Fisica() { Nome = nome, CPF = cpf }.Salvar();
                    Console.WriteLine();
                    Console.Write("Deseja Continuar cadastrando 1 = sim / 2 = não? ");
                    resp = int.Parse(Console.ReadLine());

                    if(resp == 2)
                    {
                        yesNo = false;
                        Fisica.MostrarLista();
                    }
                }
            }
            else
            {
                Console.WriteLine("Você não digitou uma opção válida, digite 1 para sim ou 2 para não!");
            }
        }
    }
}
