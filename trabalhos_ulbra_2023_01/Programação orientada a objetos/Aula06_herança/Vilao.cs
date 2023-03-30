using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_herança
{
    public class Vilao : Personagem
    {
        public void LutarHeroi(Heroi heroi)
        {
            base.Lutar(heroi);
        }
    }
}