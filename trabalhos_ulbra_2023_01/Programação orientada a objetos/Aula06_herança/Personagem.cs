using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_herança
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Forca { get; set; }
        public int Inteligencia { get; set; }
        public string [] Poderes { get; set; }

        public void Lutar(Personagem oponente)
        {
            Console.WriteLine($"{this.Nome} esta lutando contra {oponente.Nome}");

            int forcaTotalHeroi = this.Forca + this.Inteligencia;
            int forcaTotalOponente = oponente.Forca + oponente.Inteligencia;

            if(forcaTotalHeroi > forcaTotalOponente)
            {
                System.Console.WriteLine($"{this.Nome} venceu a luta!");
            }
            else if (forcaTotalHeroi < forcaTotalOponente)
            {
                System.Console.WriteLine($"{oponente.Nome} venceu a luta!");
            }
            else
            {
                System.Console.WriteLine("A luta terminou em empate");
            }
        }
    }
}