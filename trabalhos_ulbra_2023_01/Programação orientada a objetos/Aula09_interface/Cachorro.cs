using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09_interface
{
    public class Cachorro : IAnimal
    {
        public void EmitirSom()
        {
            Console.WriteLine("Auau");
        }
    }
}