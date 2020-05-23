using DataBasePessoa;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Desafio21DiasOO.Dia13.Net.Models
{
    public class Fisica : Pessoa
    {
       public Fisica() { }

        public string Cpf { get; set; }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public List<Fisica> ToList()
        {
            var lista = new List<Fisica>();
            var pessoaDb = new PessoaDB();

            foreach (DataRow row in pessoaDb.Lista().Rows)
            {
                var fisica = new Fisica();
                fisica.Id = Convert.ToInt32(row["id"]);
                fisica.Cpf = row["cpf"].ToString();
                fisica.Nome = row["nome"].ToString();
                fisica.Endereco = row["endereco"].ToString();
                
                lista.Add(fisica);

            }

            return lista;
        }
    }
}
