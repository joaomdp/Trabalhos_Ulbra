using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_herança
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        
        public Animal(string nome)
        {
            this.Nome = nome;
        }

        public abstract void Falar();
    }
}