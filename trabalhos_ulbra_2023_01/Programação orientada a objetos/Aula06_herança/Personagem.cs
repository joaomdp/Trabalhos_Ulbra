using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_herança
{
    public class Personagem
    {
        public string Nome { get; set; }
        public double Forca { get; set; }
        public double Inteligencia { get; set; }
        public string Poderes { get; set; }

        public Personagem(string nome, double forca, double inteligencia, string poderes)
        {
            this.Nome = nome;
            this.Forca = forca;
            this.Inteligencia = inteligencia;
            this.Poderes = poderes;
        }

        public void Lutar(){
            Console.WriteLine("A luta esta acontecendo!!");
        }
    }
}