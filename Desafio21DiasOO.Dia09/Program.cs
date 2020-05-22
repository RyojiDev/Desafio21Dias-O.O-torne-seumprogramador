using Desafio21DiasOO.Dia09.Interface;
using Desafio21DiasOO.Dia09.Models;
using System;

namespace Desafio21DiasOO.Dia09
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Gato();
            try{
                animal.Andar();
                
            }catch( AnimalException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            
        }
    }
}
