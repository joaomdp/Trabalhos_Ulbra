using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_herança
{
    public class Gato : Animal
    {
        public Gato(string nome):base(nome){}

        public override void Falar()
        {
            Console.WriteLine("Miau!");
        }
    }
}