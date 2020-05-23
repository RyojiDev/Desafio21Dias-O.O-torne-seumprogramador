using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia11.Models
{
    public class Fisica : Pessoa
    {
        private string v1;
        private string v2;
        private int v3;

        public Fisica() { }

        public Fisica(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }
    }
}
