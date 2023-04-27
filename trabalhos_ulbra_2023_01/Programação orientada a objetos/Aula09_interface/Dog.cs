using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09_interface
{
    public class Dog : IAnimalEstimacao
    {
        public string Nome { get; set; }
        public string Dono { get; set; }
    }
}