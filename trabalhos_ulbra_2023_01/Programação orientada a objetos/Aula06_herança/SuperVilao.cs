using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_herança
{
    public class SuperVilao : Vilao
    {
        public void SuperPoder()
        {
            Console.WriteLine($"{this.Nome} está usando seu super poder!");
        }
    }
}