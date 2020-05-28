using ORMDesafio21Dias;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia02.Models.Alunos
{
    public class Pessoa : Ctype
    {
        
        public string Nome { get; set; }

        public string Endereco { get; set; }

        [Table(IsNotOnDataBase = true)]
        public override string ConnectionString 
        { get => @"server=(LocalDB)\MSSQLLocalDB;database=PessoaTorneseUmProgramador;uid=vetMaster;password=vetmaster;"; }

        public Pessoa()
        {

        }

    }
}
