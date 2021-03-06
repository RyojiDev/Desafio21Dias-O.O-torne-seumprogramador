﻿using Desafio21DiasOO.Dia09.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia09.Models
{
    public abstract class AAnimal : IAnimal
    {
        public string Nome { get; set; }

        public abstract void Andar();

        public abstract void Correr();
    }
}
