using Desafio21DiasOO.Dia09.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia09.Models
{
    public class Gato : AAnimal
    {
       // public string Nome { get; set; }

        public override void Andar()
        {
            if (string.IsNullOrEmpty(this.Nome))
            {
                throw new AnimalException("o nome ta vazio");
            }
            throw new Exception();
           
        }

        public override void Correr()
        {
            throw new NotImplementedException();
        }
    }
}
