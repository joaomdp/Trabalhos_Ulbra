using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_herança
{
    public class Heroi : Personagem
    {
        public void LutarVilao(Vilao vilao)
        {
            base.Lutar(vilao);
        }
    }
}