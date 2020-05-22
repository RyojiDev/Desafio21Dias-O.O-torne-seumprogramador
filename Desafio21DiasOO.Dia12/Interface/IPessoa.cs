using System;
using System.Collections.Generic;
using System.Text;

namespace ExDesafio21DiasOO.Dia12.Interface
{
    public interface IPessoa
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        string Endereco { get; set; }

        void Salvar();
        
        void Excluir();
  
    }
}
