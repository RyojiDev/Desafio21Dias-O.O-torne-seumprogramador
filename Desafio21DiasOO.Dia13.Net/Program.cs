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
            /*Fisica fisica = new Fisica();

            
            foreach(Fisica lista in fisica.ToList()) { 
            
            Console.WriteLine("Nome: " + lista.Nome);
                Console.WriteLine();
                Console.WriteLine("Cpf:" + lista.Cpf);
                Console.WriteLine();
                Console.WriteLine("Endereco: " + lista.Endereco);


            }*/
            string table = "";
            List<string> cols = new List<string>();
            List<object> values = new List<object>();

            cols.Add("Id");
            cols.Add("Nome");
            cols.Add("Endereco");
            cols.Add("Tipo");
            cols.Add("CpfCnpj");

            string a = string.Join(",",cols);
            string b = string.Join(",",$"@{cols}");

            string sql = $"insert into {table} (";
            sql += "id, nome, endereco, tipo, cpfcnpj";
            sql += ") values (";
            sql += "@id, @nome, @endereco, @tipo, @cpfcnpj";
            sql += ")";
        }
    }
}
