using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_herança
{
    public class SuperHeroi : Heroi
    {
        public void SuperPoder()
        {
            System.Console.WriteLine($"{this.Nome} está usando seu poder");
        }
    }
}