using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia03.Models
{
    public class Receita
    {
        public Receita()
        {

        }

       public Receita(string nome)
        {
            Name = nome;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Peso { get; set; }
        public string Tamanho { get; set; }

        public double preco { get; set; }

        public void Salvar(Receita receita)
        {
            List<Receita> lista = new List<Receita>();
            lista.Add(receita);
        }

        public void Mostrar()
        {

            
        }

    }
}
