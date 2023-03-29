using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_herança
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome){}

        public override void Falar() // O override tem como função substituir o metodo falar da classe animal, para o metodo falar da classe na qual foi inserido;
        {
            Console.WriteLine("Au Au!");
        }
    }
}