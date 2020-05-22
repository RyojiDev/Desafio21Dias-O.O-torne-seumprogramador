using ExDesafio21DiasOO.Dia12.Interface;
using ExDesafio21DiasOO.Dia12.Models;
using System;
using System.Collections.Generic;

namespace Desafio21DiasOO.Dia12
{
    class Program
    {
        static void Main(string[] args)
        {
            new Fisica() { Nome = "Ryoji Kitano", Endereco = "rua travessa", Id = 1, Cpf = "058855222233" }.Salvar();
            new Juridica() { Nome = "Empresa", Endereco = "rua de teste", Id = 1, Cnpj = "15654654665" }.Salvar();

            var fisicas = Servico.Procurar<List<Fisica>>();
            var juridicas = Servico.Procurar<List<Juridica>>();




            var listafisica = Servico.Buscar(new Fisica());
            var listajuridica = Servico.Buscar(new Juridica());

            foreach (IPessoa ipessoa in listafisica)
            {
                Console.WriteLine("Id: " + ipessoa.Id + " Nome: " + ipessoa.Nome + " Endereço: " + ipessoa.Endereco + "Cpf: " + ((Fisica)ipessoa).Cpf);
            }

            foreach (IPessoa ipessoa in listajuridica)
            {
                Console.WriteLine("Id: " + ipessoa.Id + " Nome: " + ipessoa.Nome + " Endereço: " + ipessoa.Endereco + "Cnpj: " + ((Juridica)ipessoa).Cnpj);
            }
        }
    }
}
