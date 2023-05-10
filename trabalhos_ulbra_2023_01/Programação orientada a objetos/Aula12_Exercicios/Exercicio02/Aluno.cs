using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12_Exercicios.Exercicio02
{
    public class Aluno : IPessoa
    {
        public String Nome { get; set; }
        public int Idade { get; set; }

        public void Falar()
        {
            Console.WriteLine($"O aluno {Nome} está falando");
        }
    }
}