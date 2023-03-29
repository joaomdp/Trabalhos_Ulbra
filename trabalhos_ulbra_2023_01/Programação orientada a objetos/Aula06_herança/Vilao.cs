using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_herança
{
    public class Vilao : Personagem
    {
        public Vilao(string nome, double forca, double inteligencia, string poderes) : base(nome, forca, inteligencia, poderes){}

        public void Lutar(){}
    }
}